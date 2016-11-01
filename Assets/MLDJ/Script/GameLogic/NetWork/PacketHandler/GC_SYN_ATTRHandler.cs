//This code create by CodeEngine

using System;
using Games.LogicObj;
using Module.Log;
 using Google.ProtocolBuffers;
 using System.Collections;
using UnityEngine;
namespace SPacket.SocketInstance
 {
    public class GC_SYN_ATTRHandler : Ipacket
    {
        public uint Execute(PacketDistributed ipacket)
        {
            GC_SYN_ATTR packet = (GC_SYN_ATTR)ipacket;
            if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
            //enter your logic
            //�ж���MainPlayer��������Obj
            Obj_MainPlayer _mainPlayer = Singleton<ObjManager>.GetInstance().MainPlayer;
            PlayerData playerDataPool = GameManager.gameManager.PlayerDataPool;
           
            //Ѫ��
            bool isHpChange = false;
            if (packet.HasCurHp)
            {
                playerDataPool.MainPlayerBaseAttr.HP = packet.CurHp;
                isHpChange = true;
            }
            if (packet.HasMaxHP)
            {
                playerDataPool.MainPlayerBaseAttr.MaxHP = packet.MaxHP;
#if UNITY_ANDROID
                // ̨�尲׿�������У��ύѪ�����а�����
                if(PlatformHelper.IsChannelTW())
                {
                    PlatformHelper.SubmitRankScore(Games.GlobeDefine.GameDefine_Globe.GOOGLEPLAY_RANK_TYPE.HP, playerDataPool.MainPlayerBaseAttr.MaxHP);
                }
#endif
                isHpChange = true;
            }
            if (isHpChange && _mainPlayer!=null)
            {
                _mainPlayer.OptHPChange();
            }
            //����
            bool isMpChange = false;
            if (packet.HasCurMp)
            {
                playerDataPool.MainPlayerBaseAttr.MP = packet.CurMp;
                isMpChange = true;
            }
            if (packet.HasMaxMP)
            {
                 playerDataPool.MainPlayerBaseAttr.MaxMP = packet.MaxMP;
                isMpChange = true;
            }
            if (isMpChange && _mainPlayer != null)
            {
                _mainPlayer.OptMPChange();
            }

            //ŭ��
            bool isXpChange = false;
            if (packet.HasCurXp)
            {
                 playerDataPool.MainPlayerBaseAttr.XP = packet.CurXp;
                isXpChange = true;
            }
            if (packet.HasMaxXP)
            {
                playerDataPool.MainPlayerBaseAttr.MaxXP = packet.MaxXP;
                isXpChange = true;
            }
            if (isXpChange && _mainPlayer != null)
            {
                _mainPlayer.OptXPChange();
            }

            //�ȼ�
            if (packet.HasCurLev)
            {
                // ���������ļ�
                
                 playerDataPool.MainPlayerBaseAttr.Level = packet.CurLev;
                if (_mainPlayer)
                {
                    for (int i = 0; i < LoginData.loginRoleList.Count; i++)
                    {
                        if (LoginData.loginRoleList[i].guid == _mainPlayer.GUID)
                        {
                            LoginData.loginRoleList[i].level = packet.CurLev;
                            UserConfigData.AddRoleInfo();
                            break;
                        }
                    }

                    _mainPlayer.OptLevelChange();

                   if (LivingSkillLogic.Instance() != null)
                   {
                       LivingSkillLogic.Instance().UpdatePlayerStamina();
                   }
                    _mainPlayer.UpdateSelectDrug();
                }
                
            }
            // ����
            if (packet.HasCurExp)
            {
                playerDataPool.MainPlayerBaseAttr.Exp = packet.CurExp;
                if (_mainPlayer)
                {
                    _mainPlayer.OnExpChange();
                }
                //����ǿ������
                if (EquipShenQiStrength.Instance() != null)
                {
                    EquipShenQiStrength.Instance().UpdateExpShow();
                }
            }
            if (packet.HasOffLineExp)
            {
                playerDataPool.MainPlayerBaseAttr.OffLineExp = packet.OffLineExp;
                if (null != _mainPlayer)
                {
                    _mainPlayer.OnOffLineExpChange();
                }
            }
            //����
            if (packet.HasCurStamina)
            {
                playerDataPool.MainPlayerBaseAttr.CurStamina = packet.CurStamina;
                              
               if (LivingSkillLogic.Instance() != null)
               {
                   LivingSkillLogic.Instance().UpdatePlayerStamina();
               }
            }
            //��Ǯ
            if (packet.HasCurMoney)
            {
                playerDataPool.Money.SetMoney(MONEYTYPE.MONEYTYPE_COIN, packet.CurMoney);
#if UNITY_ANDROID
                // ̨�尲׿�������У��ύ������а�����
                if (PlatformHelper.IsChannelTW())
                {
                    PlatformHelper.SubmitRankScore(Games.GlobeDefine.GameDefine_Globe.GOOGLEPLAY_RANK_TYPE.GOLD_COINS, packet.CurMoney);
                }
#endif
                if (BackPackLogic.Instance())
                {
                    BackPackLogic.Instance().UpdateMoneyInfo();
                }

                if (FlyWingRoot.Instance())
                {
                    FlyWingRoot.Instance().UpdateMoneyInfo();
                }
//                if (SwordsManController.Instance() != null)
//                {
//                    SwordsManController.Instance().UpdateCoin();
//                }
                if (CangKuLogic.Instance())
                {
                    CangKuLogic.Instance().UpdateBackPack_Money();
                }
                //����ǿ������
                if (EquipShenQiStrength.Instance() != null)
                {
                    EquipShenQiStrength.Instance().UpdateMoneyShow();
                }
                if (GemLogic.Instance() != null)
                {
                    GemLogic.Instance().UpdateMoneyInfo();
                }
                if (null != GUIData.delMoneyChanged) GUIData.delMoneyChanged();

                if (RestaurantController.Instance() != null)
                {
                    RestaurantController.Instance().UpdateMoneyInfo();
                }

                if (EquipStrengthenLogic.Instance() != null)
                {
                    EquipStrengthenLogic.Instance().UpdateMoneyInfo();
                }

                if (SkillLevelUpRoot.Instance() != null)
                {
                    SkillLevelUpRoot.Instance().UpdateSkillInfo();
                }
                
            }

            //Ԫ��
            if (packet.HasCurYuanBao)
            {
                playerDataPool.Money.SetMoney(MONEYTYPE.MONEYTYPE_YUANBAO, packet.CurYuanBao);
                if (BackPackLogic.Instance())
                {
                    BackPackLogic.Instance().UpdateMoneyInfo();
                }
                if (YuanBaoShopLogic.Instance())
                {
                    YuanBaoShopLogic.Instance().UpdateYuanBaoInfo();
                }
                if (DailyLuckyDrawLogic.Instance())
                {
                    DailyLuckyDrawLogic.Instance().UpdateMoney();
                }
                if (CangKuLogic.Instance())
                {
                    CangKuLogic.Instance().UpdateBackPack_Money();
                }
                //����ǿ������
                if (EquipShenQiStrength.Instance() != null)
                {
                    EquipShenQiStrength.Instance().UpdateMoneyShow();
                }
                if (null != GUIData.delMoneyChanged) GUIData.delMoneyChanged();
            }

            //��Ԫ��
            if (packet.HasCurBDYuanBao)
            {
                playerDataPool.Money.SetMoney(MONEYTYPE.MONEYTYPE_YUANBAO_BIND, packet.CurBDYuanBao);
                if (FashionLogic.Instance() != null)
                {
                    FashionLogic.Instance().UpdateRuby();
                }
                if (BackPackLogic.Instance())
                {
                    BackPackLogic.Instance().UpdateMoneyInfo();
                }
                if (YuanBaoShopLogic.Instance())
                {
                    YuanBaoShopLogic.Instance().UpdateYuanBaoInfo();
                }
                if (DailyLuckyDrawLogic.Instance())
                {
                    DailyLuckyDrawLogic.Instance().UpdateMoney();
                }
                if (CangKuLogic.Instance())
                {
                    CangKuLogic.Instance().UpdateBackPack_Money();
                }
                if (RestaurantController.Instance() != null)
                {
                    RestaurantController.Instance().UpdateMoneyInfo();
                }
                if (null != GUIData.delMoneyChanged) GUIData.delMoneyChanged();
            }
//            if (packet.HasSwordsManScore)
//            {
//                playerDataPool.SwordsManScore = packet.SwordsManScore;
//                if (SwordsManController.Instance() != null)
//                {
//                    SwordsManController.Instance().UpdateSwordsManScore();
//                }
//            }

            if (packet.HasReputation)
            {
                playerDataPool.Reputation = packet.Reputation;
            }
          
            //�Ƿ���ս��״̬
            if (packet.HasIsInCombat && _mainPlayer!=null)
            {
                bool oldCombat = _mainPlayer.InCombat;
                _mainPlayer.InCombat = (packet.IsInCombat ==1 ? true:false);
                if (!_mainPlayer.InCombat && oldCombat)
                {
                    _mainPlayer.LastLeaveCombatTime = Time.time;
                }
                else if (_mainPlayer.InCombat && !oldCombat)
                {
                    _mainPlayer.LastLeaveCombatTime = 0.0f;
                }

            }
            //���� Ѫ �� �仯ʱ �����������Խ���
            if (packet.HasCurHp || packet.HasCurMp || packet.HasCurExp)
            {
                if (RoleViewLogic.Instance() !=null)
                {
                    RoleViewLogic.Instance().UpdateCurAttr();
                }
            }

            if (packet.HasGuildDKP)
            {
                playerDataPool.GuildDKP = packet.GuildDKP;
                if (GuildShopLogic.Instance() != null)
                {
                    GuildShopLogic.Instance().UpdateGuildDKP();
                }
            }
            return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
        }
    }
 }