Install required libs
pip install fastapi
pip install uvicorn[standard]


Got to fodler and run 
uvicorn ServerTest:app  --reload
RL to hit for get-message : 127.0.0.1:8000/get-message?name=Rohan