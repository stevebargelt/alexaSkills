using Microsoft.AspNetCore.Mvc;

namespace AlexaSkill.Controllers
{
    public class AlexaController : Controller
	{
		[HttpPost, Route("api/alexa/demo")]
		public dynamic Azure(dynamic request)
		{
			return new 
			{
  				version = "1.0",
  				sessionAttributes = new  { },
			  	response = new  {
    				outputSpeech = new {
      					type = "PlainText",
						text = "Hello World"
						},
					card = new {
      					type = "Simple",
      					title =  "Azure",
      					content = "Hello\ncruel world"
    				},
		    	shouldEndSession = true
  				}
			}; //end new
		}
	}
}