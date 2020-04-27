int key = 0;
if(Input.GetKey(KeyCode.RightArroow)) key = 1;
if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

float speedx = Mathf. abs(this.rigid2D.velocity.x);

if(speedx < this.maxWalkSpeed)
{
	this.rigid2D.AddForce(transform.right * key * this.walkFoce);
}
