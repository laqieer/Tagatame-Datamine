// Decompiled with JetBrains decompiler
// Type: SRPG.DrawBaseStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DF5")]
  public class DrawBaseStatus : BaseStatus
  {
    [Token(Token = "0x40078D4")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<ParamTypes, int> m_AdditionalValues;

    [Token(Token = "0x170010A4")]
    [IgnoreMember]
    public override int this[ParamTypes type]
    {
      [Token(Token = "0x6007A83"), Address(RVA = "0x3BF0C0", Offset = "0x3BDEC0", VA = "0x103BF0C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007A84")]
    [Address(RVA = "0x3BEF90", Offset = "0x3BDD90", VA = "0x103BEF90")]
    public void SetAditionalValue(ParamTypes paramType, int value)
    {
    }

    [Token(Token = "0x6007A85")]
    [Address(RVA = "0x3BEF30", Offset = "0x3BDD30", VA = "0x103BEF30")]
    public int GetAditionalValue(ParamTypes paramType) => new int();

    [Token(Token = "0x6007A86")]
    [Address(RVA = "0x3BECB0", Offset = "0x3BDAB0", VA = "0x103BECB0")]
    public void AddDrawStatus(DrawBaseStatus src)
    {
    }

    [Token(Token = "0x6007A87")]
    [Address(RVA = "0x3BF070", Offset = "0x3BDE70", VA = "0x103BF070")]
    public DrawBaseStatus()
    {
    }
  }
}
