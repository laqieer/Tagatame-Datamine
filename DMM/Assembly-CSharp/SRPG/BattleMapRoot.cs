// Decompiled with JetBrains decompiler
// Type: SRPG.BattleMapRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C3C")]
  public class BattleMapRoot
  {
    [Token(Token = "0x4002038")]
    [FieldOffset(Offset = "0x8")]
    private int m_Width;
    [Token(Token = "0x4002039")]
    [FieldOffset(Offset = "0xC")]
    private int m_Height;
    [Token(Token = "0x400203A")]
    [FieldOffset(Offset = "0x10")]
    private BattleMapRoot.Element[] m_Elements;
    [Token(Token = "0x400203B")]
    [FieldOffset(Offset = "0x14")]
    private int m_TotalCost;
    [Token(Token = "0x400203C")]
    [FieldOffset(Offset = "0x18")]
    private BattleMapRoot.Element m_Start;
    [Token(Token = "0x400203D")]
    [FieldOffset(Offset = "0x1C")]
    private BattleMapRoot.Element m_End;
    [Token(Token = "0x400203E")]
    [FieldOffset(Offset = "0x20")]
    private List<BattleMapRoot.Element> m_CalcStack;

    [Token(Token = "0x6003079")]
    [Address(RVA = "0xFD8710", Offset = "0xFD7510", VA = "0x10FD8710")]
    public void Initialize(int gridWidth, int gridHeight, Grid[,] gridMap)
    {
    }

    [Token(Token = "0x600307A")]
    [Address(RVA = "0xFD8C50", Offset = "0xFD7A50", VA = "0x10FD8C50")]
    public void Release()
    {
    }

    [Token(Token = "0x600307B")]
    [Address(RVA = "0xFD83D0", Offset = "0xFD71D0", VA = "0x10FD83D0")]
    public bool CalcRoot(
      Unit unit,
      int startX,
      int startY,
      int endX,
      int endY,
      int moveHeight,
      GridMap<int> walkableField)
    {
      return new bool();
    }

    [Token(Token = "0x600307C")]
    [Address(RVA = "0xFD8CE0", Offset = "0xFD7AE0", VA = "0x10FD8CE0")]
    private void _CalcRootInit(Unit unit, int moveHeight, GridMap<int> walkableField)
    {
    }

    [Token(Token = "0x600307D")]
    [Address(RVA = "0xFD8EF0", Offset = "0xFD7CF0", VA = "0x10FD8EF0")]
    private void _CalcRootSubroutine(BattleMapRoot.Element element)
    {
    }

    [Token(Token = "0x600307E")]
    [Address(RVA = "0xFD85D0", Offset = "0xFD73D0", VA = "0x10FD85D0")]
    public Grid[] GetRoot() => (Grid[]) null;

    [Token(Token = "0x600307F")]
    [Address(RVA = "0xFD8550", Offset = "0xFD7350", VA = "0x10FD8550")]
    private BattleMapRoot.Element GetElement(int index) => (BattleMapRoot.Element) null;

    [Token(Token = "0x6003080")]
    [Address(RVA = "0xFD8580", Offset = "0xFD7380", VA = "0x10FD8580")]
    private BattleMapRoot.Element GetElement(int x, int y) => (BattleMapRoot.Element) null;

    [Token(Token = "0x6003081")]
    [Address(RVA = "0xFD9040", Offset = "0xFD7E40", VA = "0x10FD9040")]
    public BattleMapRoot()
    {
    }

    [Token(Token = "0x2000C3D")]
    private struct Link
    {
      [Token(Token = "0x400203F")]
      [FieldOffset(Offset = "0x0")]
      public BattleMapRoot.Element element;
      [Token(Token = "0x4002040")]
      [FieldOffset(Offset = "0x4")]
      public int cost;
      [Token(Token = "0x4002041")]
      [FieldOffset(Offset = "0x8")]
      public bool is_disable_stopped;
      [Token(Token = "0x4002042")]
      [FieldOffset(Offset = "0xC")]
      public int enter;
      [Token(Token = "0x4002043")]
      [FieldOffset(Offset = "0x10")]
      public int calc_cost;
      [Token(Token = "0x4002044")]
      [FieldOffset(Offset = "0x14")]
      public int height;

      [Token(Token = "0x6003082")]
      [Address(RVA = "0xFE5690", Offset = "0xFE4490", VA = "0x10FE5690", Slot = "3")]
      public override string ToString() => (string) null;
    }

    [Token(Token = "0x2000C3E")]
    private class Element
    {
      [Token(Token = "0x4002045")]
      [FieldOffset(Offset = "0x8")]
      public Grid grid;
      [Token(Token = "0x4002046")]
      [FieldOffset(Offset = "0xC")]
      public BattleMapRoot.Link[] link;
      [Token(Token = "0x4002047")]
      [FieldOffset(Offset = "0x10")]
      public int cost;
      [Token(Token = "0x4002048")]
      [FieldOffset(Offset = "0x14")]
      public BattleMapRoot.Element root;

      [Token(Token = "0x6003083")]
      [Address(RVA = "0xFE4030", Offset = "0xFE2E30", VA = "0x10FE4030", Slot = "3")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6003084")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Element()
      {
      }
    }
  }
}
