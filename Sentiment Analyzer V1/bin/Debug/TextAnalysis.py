from nltk.sentiment.vader import SentimentIntensityAnalyzer
import nltk
import matplotlib.pyplot as plt
import tkinter
from tkinter import messagebox

def Analyze(input_text):
    pos = 0
    neg = 0
    total = 0
    sentence = input_text
    sent_text = nltk.sent_tokenize(sentence)
    for sentence in sent_text:
        sid = SentimentIntensityAnalyzer()
        ss = sid.polarity_scores(sentence)  
        neg += ss["neg"]
        pos += ss["pos"]
        print(ss)

    total = neg + pos
    # hide main window
    root = tkinter.Tk()
    root.withdraw()
    if(total == 0):
       messagebox.showerror("Error", "No words to determine sentiments!!!!")
       root.quit()
    root.destroy()
    PosResult = float((pos/total)*100)
    NegResult = float((neg/total)*100)
    # print("Positive : ", ((pos/total)*100))
    # print("Negative : ", ((neg/total)*100))
    labels = ['Negative', 'Positive']
    sizes = [NegResult, PosResult]
    colors = ['Red', 'Green']
    Result, ax1 = plt.subplots()
    explode = (0, 0.1)  # only "explode" the 2nd slice 
    ax1.pie(sizes, explode=explode, labels=labels, autopct='%1.1f%%',
        shadow=True, startangle=90, colors=colors)
    ax1.axis('equal')  # Equal aspect ratio ensures that pie is drawn as a circle.
    ax1.set_title("Analysis")
    plt.show()
