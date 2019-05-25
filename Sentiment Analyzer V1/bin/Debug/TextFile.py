import TextAnalysis as ta 
import sys

fileName = sys.argv[1]
f = open(fileName,"r")
sentence = ""
for word in f.read().split():
        sentence += word 
        sentence += " "
print(sentence)
ta.Analyze(sentence)

