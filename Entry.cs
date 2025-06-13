public class Entry 
{
  public int[] choices = {1,2,3,4,5,6,7,8,9};

  // Constructor
  public Entry(int row, int col, int val) {
    Row = row;
    Col = col;
    Val = val;
  }

  // Getters-Setters
  public int Row { get; init; }
  public int Col { get; init; }
  public bool final { get; set; }
  public int Val { get; set; }
  
}
