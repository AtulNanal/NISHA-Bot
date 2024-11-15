from fastapi import FastAPI
from pydantic import BaseModel
import random

app = FastAPI()


#APT to test if server is UP
@app.get("/test")
def hello():
    return {'Status': True,
            'Message': "Congrats, Your Python Server is UPPP.."}

#APT for GET with one parameter
@app.get("/get-message")
def hello(name: str):
    return {'Message': "Congrats " + name + '! Your GET API is working good!'}


#APT for POST 
@app.post("/post-message")
def hello(name: str):
    return {'Message': "Congrats " + name + '! Your POST API is working good!'}

# Define the structure of the incoming request (Pydantic model)
class ChatRequest(BaseModel):
    message: str


@app.post("/chatbot/")
async def get_chatbot_response(request: ChatRequest):
    user_message = request.message
    print(f"Received message: {user_message}")

    # Generate a response
    responses = [
        "Hello, how can I help you?",
        "I'm a chatbot! How are you today?",
        "Tell me more about your problem.",
        "How can I assist you with that?"
    ]

    # send back a random response
    bot_response = random.choice(responses)
    return {"response": bot_response}