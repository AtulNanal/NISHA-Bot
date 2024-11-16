# Chatbot Deployment

step 1 : Download the zip of repo - https://github.com/patrickloeber/chatbot-deployment  and extract it.

step 2 : Clone the repo https://github.com/AtulNanal/NISHA-Bot  and switch to development branch, copy the contents of the chatbot-deployment repo to ai folder of NISHA-Bot Samples/PythonAPI/ai 

step 3 [one time]: Open the terminal at chat-deployment and type following command in cmd : pip install Flask torch torchvision nltk

Step 4 [one time]: Launch a python terminal by typing "python" in cmd and type following commands:
	>>import nltk
	>>nltk.download(punkt_tab) 
	>>exit()

Step 5 : Now type following command in cmd "uvicorn ServerTest:app  --reload" and ensure that server is up. Post that simply launch the Unity Project.