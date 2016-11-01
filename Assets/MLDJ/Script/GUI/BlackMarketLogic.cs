﻿/********************************************************************
	创建时间:	2014/08/15 10:34
	全路径:		\Main\Project\Client\Assets\MLDJ\Script\GUI\BlackMarketLogic.cs
	创建人:		luoy
	功能说明:	黑市
	修改记录:
*********************************************************************/

using System;
using Games.LogicObj;
using GCGame;
using UnityEngine;
using System.Collections;

public class BlackMarketLogic : MonoBehaviour
{
  //  public UILabel m_JinBiNumLable;
    public UILabel m_YuanBaoNumLable;
    public UILabel m_BindYBNumLable;
    public UILabel m_PageLable;
    public GameObject m_GoodItem;
    public GameObject m_GoodGird;
    public UIGrid     m_UIGrid;
    private GameObject[] m_GoodItemGameObj =new GameObject[(int)BLACKMARKETDATE.MAXNUMPAGE];
    public TabController m_BuyTypeController;
    public GameObject m_BindBuy;
    public GameObject m_UnBindBuy;
    private int m_nCurPage =1;
    private int m_nUseYBType = -1;
    public int UseYBType
    {
        get { return m_nUseYBType; }
        set { m_nUseYBType = value; }
    }
    public int CurPage
    {
        get { return m_nCurPage; }
        set { m_nCurPage = value; }
    }
    private int m_nMaxPage =1;
    void Awake()
    {
        m_Instance = this;
    }
    private static BlackMarketLogic m_Instance = null;
    public static BlackMarketLogic Instance()
    {
        return m_Instance;
    }
    void OnDestroy()
    {
        m_Instance = null;
    }
	// Use this for initialization
	void Start ()
    {
	    //显示金钱数
//	    int nCoin = GameManager.gameManager.PlayerDataPool.Money.GetMoney_Coin();
	    int nPlayerYuanBao = GameManager.gameManager.PlayerDataPool.Money.GetMoney_YuanBao();
	    int nPlayerYuanBaoBind = GameManager.gameManager.PlayerDataPool.Money.GetMoney_YuanBaoBind();
  //      m_JinBiNumLable.text = nCoin.ToString();
	    m_YuanBaoNumLable.text = nPlayerYuanBao.ToString();
        m_BindYBNumLable.text = nPlayerYuanBaoBind.ToString();
        m_UnBindBuy.GetComponent<BoxCollider>().enabled = (nPlayerYuanBao != 0);
        m_BindBuy.GetComponent<BoxCollider>().enabled = (nPlayerYuanBaoBind != 0);
        m_BuyTypeController.ChangeTab("2Bind");
        m_BuyTypeController.delTabChanged = BuyTypeOnClick;
        if (nPlayerYuanBaoBind == 0)
        {
            if (nPlayerYuanBao != 0)
            {
                m_BuyTypeController.ChangeTab("1UnBind");
            }
        }
        if (nPlayerYuanBao == 0)
        {
            m_BuyTypeController.ChangeTab("2Bind");
        }
        //加载货物Item
        if (m_GoodItem!=null)
	    {
            for (int nIndex = 0; nIndex < (int)BLACKMARKETDATE.MAXNUMPAGE; ++nIndex)
            {
                GameObject _gameObject = Utils.BindObjToParent(m_GoodItem, m_GoodGird, (nIndex + 1000).ToString());
                _gameObject.SetActive(false);
                m_UIGrid.Reposition();
                m_GoodItemGameObj[nIndex] = _gameObject;
            }
	    }
        //请求数据
        AskGoodInfo();
    }

    void BuyTypeOnClick(TabButton value)
    {
         if (value.name == "1UnBind")
        {
            m_nUseYBType = 0;
        }
        else if (value.name == "2Bind")
        {
            m_nUseYBType = 1;
        }        
    }
    public void UpdateGoodInfo(GC_RET_BLACKMARKETITEMINFO packet)
    {
        //显示金钱数
//        int nCoin = GameManager.gameManager.PlayerDataPool.Money.GetMoney_Coin();
        int nPlayerYuanBao = GameManager.gameManager.PlayerDataPool.Money.GetMoney_YuanBao();
        int nPlayerYuanBaoBind = GameManager.gameManager.PlayerDataPool.Money.GetMoney_YuanBaoBind();
  //      m_JinBiNumLable.text = nCoin.ToString();
        m_YuanBaoNumLable.text = nPlayerYuanBao.ToString();
        m_BindYBNumLable.text = nPlayerYuanBaoBind.ToString();
        m_UnBindBuy.GetComponent<BoxCollider>().enabled = (nPlayerYuanBao != 0);
        m_BindBuy.GetComponent<BoxCollider>().enabled = (nPlayerYuanBaoBind != 0);
        if (nPlayerYuanBaoBind == 0)
        {
            if (nPlayerYuanBao != 0)
            {
                m_BuyTypeController.ChangeTab("1UnBind");
            }
        }
        if (nPlayerYuanBao == 0)
        {
            m_BuyTypeController.ChangeTab("2Bind");
        }
        //最大页数
        m_nMaxPage = packet.MaxPage;
        m_PageLable.text = String.Format("{0}/{1}", m_nCurPage, m_nMaxPage);
        for (int nIndex = 0; nIndex < (int)BLACKMARKETDATE.MAXNUMPAGE; ++nIndex)
        {
            if (m_GoodItemGameObj[nIndex] !=null)
            {
                BlackMarketItemInfo goodInfo =new BlackMarketItemInfo();
                goodInfo.CleanUp();
                bool isHaveInfo = false;
                //索引
                if (nIndex<packet.ItemIndexCount)
                {
                    goodInfo.ItemIndex = packet.GetItemIndex(nIndex);
                    isHaveInfo = true;
                }
                //ID
                if (nIndex<packet.ItemDataIdCount)
                {
                    goodInfo.ItemInfo.DataID = packet.GetItemDataId(nIndex);
                    isHaveInfo = true;
                }
                //是否绑定
                if (nIndex < packet.IsBindCount)
                {
                    goodInfo.ItemInfo.BindFlag = (packet.GetIsBind(nIndex)==1);
                    isHaveInfo = true;
                }
                //数量
                if (nIndex<packet.ItemCountCount)
                {
                    goodInfo.ItemCount = packet.GetItemCount(nIndex);
                    isHaveInfo = true;
                }
                //价格
                if (nIndex<packet.ItemPriceCount)
                {
                    goodInfo.ItemPrice = packet.GetItemPrice(nIndex);
                    isHaveInfo = true;
                }
                //金钱类型
                if (nIndex<packet.ItemMoneyTypeCount)
                {
                    goodInfo.ItemMoneyType = packet.GetItemMoneyType(nIndex);
                    isHaveInfo = true;
                }
                //显示
                if (isHaveInfo)
                {
                    BlackMarketItemLogic itemLogic = m_GoodItemGameObj[nIndex].GetComponent<BlackMarketItemLogic>();
                    if (itemLogic != null)
                    {
                        itemLogic.InitItemInfo(goodInfo);
                    }
                }
                //隐藏
                else
                {
                    m_GoodItemGameObj[nIndex].gameObject.SetActive(false);
                }

            }
        }
        m_UIGrid.Reposition();
    }
    void AskGoodInfo()
    {
        CG_ASK_BLACKMARKETITEMINFO askPak= (CG_ASK_BLACKMARKETITEMINFO)PacketDistributed.CreatePacket(MessageID.PACKET_CG_ASK_BLACKMARKETITEMINFO);
        askPak.Askpage = m_nCurPage;
        askPak.SendPacket();
    }
    public void CloseWindow()
    {
        //关闭窗口
        UIManager.CloseUI(UIInfo.BlackMarket);
    }

    void OnClickChongZhi()
    {
        RechargeData.PayUI();
    }
    void LeftBtClick()
    {
        if (m_nCurPage>1)
        {
            m_nCurPage--;
            AskGoodInfo();
        }
    }

    void RigthBtClick()
    {
        if (m_nCurPage < m_nMaxPage)
        {
            m_nCurPage++;
            AskGoodInfo();
        }
    }
}