import sys
import os
from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
from pydantic import BaseModel
import random

# Add folder 2 to the system path
# sys.path.append(os.path.join(os.path.dirname(__file__), 'ai'))

# Now you can import your modules from folder 2
from chat import get_response

app = FastAPI()

# Allow CORS from any origin (or specify the Unity app URL)
app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],  # Allows all origins, you can specify your Unity build URL here
    allow_credentials=True,
    allow_methods=["*"],  # Allows all HTTP methods (GET, POST, etc.)
    allow_headers=["*"],  # Allows all headers
)


app = FastAPI()

# APT to test if server is UP
@app.get("/test")
def hello():
    return {'Status': True,
            'Message': "Congrats, Your Python Server is UPPP.."}

# APT for GET with one parameter
@app.get("/get-message")
def hello(name: str):
    return {'Message': "Congrats " + name + '! Your GET API is working good!'}

# APT for POST
@app.post("/post-message")
def hello(name: str):
    return {'Message': "Congrats " + name + '! Your POST API is working good!'}

# Define the structure of the incoming request (Pydantic model)
class ChatRequest(BaseModel):
    message: str

# Use the imported function
def chat_to_nisha(msg):
    return get_response(msg)

@app.post("/chatbot/")
async def get_chatbot_response(request: ChatRequest):
    user_message = request.message
    print(f"Received message: {user_message}")

    # Call the chat_to_nisha function and get the response
    bot_response = chat_to_nisha(user_message)
    return {"response": bot_response}