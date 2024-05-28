from flask import Flask, request, jsonify

app = Flask(__name__)

@app.route('/process_data', methods=['POST'])
def process_data():
    data = request.get_json()
    print(f"Received data: {data}")

    # 假设 data 是一个字典，将数据转换为字符串再进行拼接
    result_message = str(data) + ' from flask to blazor'
    result = {"status": "success", "data_received": result_message}

    return jsonify(result)

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5000)
