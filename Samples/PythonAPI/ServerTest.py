from fastapi import FastAPI

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