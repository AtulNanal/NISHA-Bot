import numpy as np
import nltk
from nltk.stem.porter import PorterStemmer
stemmer = PorterStemmer()

def tokenize(sentence):
    """
    split sentence into array of words/tokens
    a token can be a word or punctuation character, or number
    """
    return nltk.word_tokenize(sentence)

def stem(word):
    """
    stemming = find the root form of the word
    examples:
    words = ["organize", "organizes", "organizing"]
    words = [stem(w) for w in words]
    -> ["organ", "organ", "organ"]
    """
    return stemmer.stem(word.lower())

def bag_of_words(tokenized_sentence, words):
    """
    return bag of words array:
    1 for each known word that exists in the sentence, 0 otherwise
    example:
    sentence = ["hello", "how", "are", "you"]
    words = ["hi", "hello", "I", "you", "bye", "thank", "cool"]
    bog   = [  0 ,    1 ,    0 ,   1 ,    0 ,    0 ,      0]
    """
    sentence_words = [stem(word) for word in tokenized_sentence]
    word_dict = {w: idx for idx, w in enumerate(words)}
    bag = np.zeros(len(words), dtype=np.float32)
    for word in sentence_words:
        if word in word_dict:
            bag[word_dict[word]] = 1
    return bag

def extract_keywords(sentence):
    tokens = tokenize(sentence)
    keywords = [stem(word) for word in tokens if word.isalnum()]
    return keywords