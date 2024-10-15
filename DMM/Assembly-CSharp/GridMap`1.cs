// Decompiled with JetBrains decompiler
// Type: GridMap`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20000FA")]
public class GridMap<T>
{
  [Token(Token = "0x40004BD")]
  [FieldOffset(Offset = "0x0")]
  private T[] _data;
  [Token(Token = "0x40004BE")]
  [FieldOffset(Offset = "0x0")]
  private int _w;
  [Token(Token = "0x40004BF")]
  [FieldOffset(Offset = "0x0")]
  private int _h;

  [Token(Token = "0x17000104")]
  public int w
  {
    [Token(Token = "0x600067F")] get => new int();
  }

  [Token(Token = "0x17000105")]
  public int h
  {
    [Token(Token = "0x6000680")] get => new int();
  }

  [Token(Token = "0x17000106")]
  public T[] data
  {
    [Token(Token = "0x6000681")] get => (T[]) null;
  }

  [Token(Token = "0x6000682")]
  public GridMap(int wSize, int hSize)
  {
  }

  [Token(Token = "0x6000683")]
  protected GridMap()
  {
  }

  [Token(Token = "0x6000684")]
  public bool isValid(int x, int y) => new bool();

  [Token(Token = "0x6000685")]
  public T get(int x, int y) => (T) null;

  [Token(Token = "0x6000686")]
  public T get(int x, int y, T defaultValue) => (T) null;

  [Token(Token = "0x6000687")]
  public void set(int x, int y, T src)
  {
  }

  [Token(Token = "0x6000688")]
  public void set(int idx, T src)
  {
  }

  [Token(Token = "0x6000689")]
  public void resize(int cx, int cy)
  {
  }

  [Token(Token = "0x600068A")]
  public void fill(T value)
  {
  }

  [Token(Token = "0x600068B")]
  public GridMap<T> clone() => (GridMap<T>) null;

  [Token(Token = "0x600068C")]
  public void RotateRight()
  {
  }

  [Token(Token = "0x600068D")]
  public void RotateLeft()
  {
  }
}
