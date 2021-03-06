/// <summary>
/// Generic Mono singleton.
/// </summary>
using UnityEngine;

namespace Engine
{
	public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>{
		
		private static T m_Instance = null;
	    
		public static T Instance{
	        get{
				if( m_Instance == null ){
	            	m_Instance = GameObject.FindObjectOfType(typeof(T)) as T;
	            }
	            return m_Instance;
	        }
	    }
	
	    protected void Awake(){   
	        if( m_Instance == null ){
	            m_Instance = this as T;
	        }
	    }
	
	    void OnDestroy()
	    {
	        m_Instance = null;
	    }
	    protected void OnApplicationQuit(){
	        m_Instance = null;
	    }
	}
}