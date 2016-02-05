
import UIKit
import Foundation

let iosClassMates = (
    (firstName: "Chidi", lastName: "Emeh", email: "chidiemeh184@gmail.com" ),
    (firstName: "Peter", lastName: "Carswell", email: "pcarswell@cscc.edu" ),
    (firstName: "Jeffrey", lastName: "Mink", email: "jmink@cscc.edu" ),
    (firstName: "Duane", lastName: "Soisson", email: "doission@cscc.edu" ),
    (firstName: "Jorge", lastName: "Vallejos", email: "jvallejos@cscc.edu" ),
    (firstName: "Max", lastName: "Payne", email: "mpayne@cscc.edu" )
)

let iosClassMatesNewStudentAdded = (firstName: "Carson", lastName: "Payne", email: "cpayne@cscc.edu" )

let mirrow = Mirror(reflecting: iosClassMates)

for (label) in mirrow.children {
    //print(label.value)
}


let me = "My name is \(iosClassMates.0.firstName) \(iosClassMates.0.lastName), my email is \(iosClassMates.0.email)."

// The Second String
var otherStudents = "Other students in my class are \(iosClassMates.1.firstName), \(iosClassMates.2.firstName), \(iosClassMates.3.firstName), \(iosClassMates.4.firstName) and \(iosClassMates.5.firstName)."

// The Third String
let lastStudent = otherStudents.substringWithRange(otherStudents.endIndex.advancedBy(-4)..<otherStudents.endIndex.advancedBy(-1))

//The Fourth String
var otherStudentsNew = otherStudents


let range = otherStudents.endIndex.advancedBy(-4)..<otherStudents.endIndex.advancedBy(-0)
otherStudentsNew.replaceRange(range, with: "\(iosClassMatesNewStudentAdded.firstName.uppercaseString) was added.")

// The 3rd Student
let thirdStudent = otherStudents.substringWithRange(otherStudents.startIndex.advancedBy(47)..<otherStudents.endIndex.advancedBy(-16))

//The 4th Student
let fourthStudent = otherStudents.substringWithRange(otherStudents.startIndex.advancedBy(54)..<otherStudents.endIndex.advancedBy(-8))




//Expected output
print(me)
print(otherStudents)
print("\(lastStudent) dropped this class.")
print(String(otherStudentsNew))
print("\(thirdStudent) and \(fourthStudent)are in the class.")


