print("How many natural nummbers do you want to print?", terminator : "")
var Count = Int(readLine()!)!
print("The first \(Count) natural numbers are", terminator : "")
for Counter in 1...Count{
  print(" \(Counter)", terminator : "")
}
print(".")