import java.util.Scanner;


public class Main{

    public static void main(String[] args) {
        System.out.println("Hello World");
        Scanner input = new Scanner(System.in);
        System.out.print("Input Note name: ");
        String name = input.nextLine();

        System.out.print("Input Note Description: ");
        String description = input.nextLine();
        System.out.println("");
        Note note = new Note(name, description);
        note.DisplayInformation();
    }

}

public class Note{

    private String NoteName;
    private String NoteDescription;

    //Getters
    public String getNoteName() {
        return NoteName;
    }

    public String getNoteDescription() {
        return NoteDescription;
    }

    //Setters
    public void setNoteName(String NoteName) {
        this.NoteName = NoteName;
    }

    public void setNoteDescription(String NoteDescription) {
        this.NoteDescription = NoteDescription;
    }

    public Note(String noteName, String noteDescription) {
        this.NoteName = noteName;
        this.NoteDescription = noteDescription;
    }

    public void DisplayInformation(){
        System.out.println("Note: " + this.NoteName + "\n" + "Note Description: " + this.NoteDescription);
    }

}

//Implement NoteBook Maybe