Option Strict On

Module Program

    ' --- Testdaten (Teil 1 Stil) ----
    Dim UserData As String =
        "U001,Max Johnson|" &
        "U002,Emily Smith|" &
        "U003,Daniel Brown|" &
        "U004,Laura Wilson|" &
        "U005,Michael Taylor|" &
        "U006,Sarah Anderson|" &
        "U007,James Miller|" &
        "U008,Anna Davis|" &
        "U009,Robert Clark|" &
        "U010,Linda Moore|" &
        "U011,Thomas Martin|" &
        "U012,Jessica Thompson|" &
        "U013,Kevin White|" &
        "U014,Rachel Harris|" &
        "U015,Steven Lewis"

    Dim Users() As String = UserData.Split("|"c)

    Dim LibraryData As String =
        "978-0-13-110362-7,Introduction to Programming,John Smith,available|" &
        "978-0-201-03801-9,Data Structures Basics,Alice Brown,available|" &
        "978-0-262-03384-8,Algorithms Explained,Thomas White,available|" &
        "978-0-321-48681-3,Software Engineering Fundamentals,Emily Johnson,available|" &
        "978-1-491-94600-8,Learning VB.NET,Michael Green,available|" &
        "978-0-596-52068-7,Clean Code,Robert Martin,available|"

    Dim Library() As String = LibraryData.Split("|"c)

    Sub Main()
        Dim choice As Integer = -1

        Do
            Console.Clear()
            Console.WriteLine("===== Library Menu =====")
            Console.WriteLine("(1) New user")
            Console.WriteLine("(2) Show all books")
            Console.WriteLine("(3) Show all users")
            Console.WriteLine("(4) Borrow a book (ISBN + UserID)")
            Console.WriteLine("(5) Return (not implemented)")
            Console.WriteLine("(6) Close")
            Console.Write("Input: ")

            Dim input As String = Console.ReadLine()
            If Not Integer.TryParse(input, choice) Then
                Console.WriteLine("Invalid input. Please enter a number 1-6.")
                Pause()
                Continue Do
            End If

            Select Case choice
                Case 1
                    AddUser()
                Case 2
                    ShowBooks()
                Case 3
                    ShowUsers()
                Case 4
                    BorrowBook()
                Case 5
                    Console.WriteLine("Return is not implemented in this version.")
                Case 6
                    Console.WriteLine("Goodbye!")
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid option. Please enter a number 1-6.")
            End Select

            If choice <> 6 Then Pause()
        Loop

    End Sub
End Module
