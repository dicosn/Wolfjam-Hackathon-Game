import subprocess

# Execute the Python script in a separate terminal window
subprocess.run(["start", "cmd", "/c", "python battle.py"], shell=True)