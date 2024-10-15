// Decompiled with JetBrains decompiler
// Type: SRPG.TrickMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BCB")]
  public class TrickMap
  {
    [Token(Token = "0x4001DEC")]
    [FieldOffset(Offset = "0x8")]
    private Unit m_Owner;
    [Token(Token = "0x4001DED")]
    [FieldOffset(Offset = "0xC")]
    private GridMap<TrickMap.Data> m_DataMap;

    [Token(Token = "0x170002C6")]
    public Unit owner
    {
      [Token(Token = "0x6002F72"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
      [Token(Token = "0x6002F73"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Unit) null;
      }
    }

    [Token(Token = "0x6002F74")]
    [Address(RVA = "0xFD31A0", Offset = "0xFD1FA0", VA = "0x10FD31A0")]
    public TrickMap()
    {
    }

    [Token(Token = "0x6002F75")]
    [Address(RVA = "0xFD2EC0", Offset = "0xFD1CC0", VA = "0x10FD2EC0")]
    public void Initialize(int w, int h)
    {
    }

    [Token(Token = "0x6002F76")]
    [Address(RVA = "0xFD2E30", Offset = "0xFD1C30", VA = "0x10FD2E30")]
    public void Clear()
    {
    }

    [Token(Token = "0x6002F77")]
    [Address(RVA = "0xFD3100", Offset = "0xFD1F00", VA = "0x10FD3100")]
    public void SetData(TrickMap.Data data)
    {
    }

    [Token(Token = "0x6002F78")]
    [Address(RVA = "0xFD2E70", Offset = "0xFD1C70", VA = "0x10FD2E70")]
    public TrickMap.Data GetData(int x, int y) => (TrickMap.Data) null;

    [Token(Token = "0x6002F79")]
    [Address(RVA = "0xFD2FA0", Offset = "0xFD1DA0", VA = "0x10FD2FA0")]
    public bool IsFailData(int x, int y) => new bool();

    [Token(Token = "0x6002F7A")]
    [Address(RVA = "0xFD3050", Offset = "0xFD1E50", VA = "0x10FD3050")]
    public bool IsGoodData(int x, int y) => new bool();

    [Token(Token = "0x2000BCC")]
    public class Data
    {
      [Token(Token = "0x4001DEE")]
      [FieldOffset(Offset = "0x8")]
      private TrickData data;
      [Token(Token = "0x4001DEF")]
      [FieldOffset(Offset = "0xC")]
      private TrickParam param;

      [Token(Token = "0x170002C7")]
      public int x
      {
        [Token(Token = "0x6002F7B"), Address(RVA = "0xFC8A60", Offset = "0xFC7860", VA = "0x10FC8A60")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170002C8")]
      public int y
      {
        [Token(Token = "0x6002F7C"), Address(RVA = "0xFC8A90", Offset = "0xFC7890", VA = "0x10FC8A90")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6002F7D")]
      [Address(RVA = "0xFC8A10", Offset = "0xFC7810", VA = "0x10FC8A10")]
      public Data(TrickData _data)
      {
      }

      [Token(Token = "0x6002F7E")]
      [Address(RVA = "0xFC7EC0", Offset = "0xFC6CC0", VA = "0x10FC7EC0")]
      public int CalcHeal(Unit unit) => new int();

      [Token(Token = "0x6002F7F")]
      [Address(RVA = "0xFC7E90", Offset = "0xFC6C90", VA = "0x10FC7E90")]
      public int CalcDamage(Unit unit) => new int();

      [Token(Token = "0x6002F80")]
      [Address(RVA = "0xFC8940", Offset = "0xFC7740", VA = "0x10FC8940")]
      public bool IsVisual(Unit unit) => new bool();

      [Token(Token = "0x6002F81")]
      [Address(RVA = "0xFC8870", Offset = "0xFC7670", VA = "0x10FC8870")]
      public bool IsVaild(Unit unit) => new bool();

      [Token(Token = "0x6002F82")]
      [Address(RVA = "0xFC84A0", Offset = "0xFC72A0", VA = "0x10FC84A0")]
      public bool IsFail(Unit unit) => new bool();

      [Token(Token = "0x6002F83")]
      [Address(RVA = "0xFC8480", Offset = "0xFC7280", VA = "0x10FC8480")]
      public bool IsDamage() => new bool();

      [Token(Token = "0x6002F84")]
      [Address(RVA = "0xFC86A0", Offset = "0xFC74A0", VA = "0x10FC86A0")]
      public bool IsHeal() => new bool();

      [Token(Token = "0x6002F85")]
      [Address(RVA = "0xFC8440", Offset = "0xFC7240", VA = "0x10FC8440")]
      public bool IsBuffEffect() => new bool();

      [Token(Token = "0x6002F86")]
      [Address(RVA = "0xFC8460", Offset = "0xFC7260", VA = "0x10FC8460")]
      public bool IsCondEffect() => new bool();

      [Token(Token = "0x6002F87")]
      [Address(RVA = "0xFC7EF0", Offset = "0xFC6CF0", VA = "0x10FC7EF0")]
      public int GetBuffPriority(Unit self) => new int();
    }
  }
}
