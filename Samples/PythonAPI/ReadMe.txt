Install required libs
pip install fastapi
pip install uvicorn[standard]


Got to fodler and run 
uvicorn ServerTest:app  --reload

URL to hit for get-message : 
127.0.0.1:8000/get-message?name=Rohan
http://localhost:8000/get-message?name=Rohan


Details for POST method
http://localhost:8000/post-message?name=hey-rohan


