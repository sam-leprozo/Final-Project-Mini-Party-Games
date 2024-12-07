from flask import Flask, render_template
from flask_socketio import SocketIO, emit

app  = Flask(__name__)
socketio = SocketIO(app)

#track players who connected 
connected_players = 0

@app.route('/')
def index():
    return render_template('index.html')

@socketio.on('player_joined')
def handle_player_joined():
    global connected_players
    connected_players += 1
    emit('update_player_count', connected_players, broadcast=True)

@socketio.on('player_left')
def handle_player_left():
    global connected_players
    if connected_players > 0:
        connected_players -= 1
    emit('update_player_count', connected_players, broadcast=True)

@socketio.on('play_game')
def handle_play_game():
    if 4 <= connected_players <= 6:
        emit('start_game', broadcast=True)
    else:
        emit('error_message', 'Not enough players to start the game!')

if __name__ == '__main__':
    socketio.run(app, debug=True)
