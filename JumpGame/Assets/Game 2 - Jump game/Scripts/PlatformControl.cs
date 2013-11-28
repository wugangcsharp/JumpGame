using UnityEngine;
using System.Collections;

public class PlatformControl : MonoBehaviour {
	/// <summary>
	/// 当前对象transform
	/// </summary>
	Transform m_transform;
	/// <summary>
	/// 当前对象碰撞器
	/// </summary>
	BoxCollider boxCollider;
	// Use this for initialization
	void Start () {
		m_transform=this.transform;
		boxCollider=m_transform.GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay( Collider collider){
		if(collider.tag.CompareTo("Player")==0){
			//比较主角高度和当前平台高度
			if(collider.transform.position.y>m_transform.position.y){
				//添加碰撞效果
				boxCollider.isTrigger=false;
			}
			else{
				//移除碰撞效果
				boxCollider.isTrigger=true;
			}
		}
	}
	void OnCollisionStay(Collision collision){
		if(collision.collider.tag.CompareTo("Player")==0){
			//比较主角高度和当前平台高度
			if(collision.collider.transform.position.y>m_transform.position.y){
				//添加碰撞效果
				boxCollider.isTrigger=false;
			}
			else{
				//移除碰撞效果
				boxCollider.isTrigger=true;
			}
		}
	}
}
