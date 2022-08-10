from flask import Flask
from flask import request

app = Flask(__name__)



@app.route('/subtract')
def subtract():
  x= float(request.args.get('x'))
  y= float(request.args.get('y'))

  return str(x - y)

@app.route('/healthcheck')
def healthcheck():
  return "Healthy"

if __name__ == "__main__":
    app.run(host='localhost', port=5175)

    