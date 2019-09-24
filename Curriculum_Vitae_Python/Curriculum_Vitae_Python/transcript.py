class transcript(object):
    def __init__(self,name,quiz,midterm,final):
        self._name=name#name代表姓名的私有（private）字串資料項目
        self._quiz=quiz#quiz代表小考成績的私有數值資料項目
        self._midterm=midterm#midterm代表期中考成績的私有數值資料項目
        self._final=final#var_final代表期末考成績的私有數值資料項目
    
    def calScore(self):#計算學期成績（score）的私有數值資料項目
        return self._quiz*0.15+self._midterm*0.35+self._final*0.5
    
    def calGrade(self):#計算成績等第（grade）的私有字元資料項目
        score = self.calScore()
        if score>=90:
            grade = 'A'
        elif score>=80:
            grade = 'B'
        elif score>=70:
            grade = 'C'
        elif score>=60:
            grade = 'D'
        else:
            grade = 'E'
        return grade
    
    def printReport(self):#顯示出學生姓名、學期成績與成績等第結果
        score = self.calScore()
        grade = self.calGrade()
        print("name:",self._name,"\nquiz    midterm final    score   grade\n",self._quiz,"  ",self._midterm,"  ",self._final,"  ",score,"  ",grade)

