using UnityEngine;

namespace Pipe
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] GameObject topPipe;
        [SerializeField] GameObject bottomPipe;
        [SerializeField] float distance;
        [SerializeField] float speed;
        PipeMovement pipeMovement;
        PipePoint pipePoint;
        PipeDead pipeDead;

        public void SetDistance(float _distance,float _speed)
        {
            distance = _distance;
            speed = _speed;
            topPipe.transform.localPosition = new Vector3(0, distance, 0);
            bottomPipe.transform.localPosition = new Vector3(0, -distance, 0);
            pipeMovement = new PipeMovement(transform, speed,Destroy);
            pipeMovement.StartMove();
            pipePoint = new PipePoint();
            pipeDead = new PipeDead();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Player")
            {
                pipePoint.PointUpdate();
            }  
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
             if(collision.gameObject.tag == "Player")
             {
                pipeDead.Dead();
             }
        }
        public void Destroy()
        {
            Destroy(gameObject);
        }
    }
}
