import sys
import assemblyai
import TextAnalysis as ta

print("Type of cmd line arguments are ",type(sys.argv))
fileName = sys.argv[1]
try:
    aai = assemblyai.Client(token='Your Assembly AI token ID')
    transcript = aai.transcribe(filename=fileName)

    while transcript.status != 'completed':
        transcript = transcript.get()
        text = transcript.text
        print(text)
    text = transcript.text
    print(text)
    ta.Analyze(text)
except ConnectionError:
    print("Error occured, Please check your internet connection.")