package Week10ErrorHandlingAndDB;

public class DivdeByZeroErrorHanding {

	/*int doDivision (int a, int b){
		return a/b;		
		}*/
	
	float doDivision (float a, float b){
		return a/b;		
		}
	
	int doDivision (int a, int b){
		return a/b;		
		}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
		int a,b,c;
		a =1; 
		b =0;
		
		float a,b,c; 
		a=1f;
		b=0f;
		
		
		try {
		c =obj.doDivision(a,2f);
		System.out.println("c=(a/b        :" + c);
		
		c =obj.doDivision(a,b);
		System.out.println("c=(a/b        :" + c);
			
		}
		
		catch (Exception e) 
		{
			System.out.println("e           :" + e); // shows error
			System.out.println("e.Message" + e.getMessage()); // shows no error 
		}
		}

}
