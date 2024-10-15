// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureNumParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001982")]
  public class AdventureNumParam
  {
    [Token(Token = "0x4005CE8")]
    [FieldOffset(Offset = "0x8")]
    private int mAdvNum;
    [Token(Token = "0x4005CE9")]
    [FieldOffset(Offset = "0xC")]
    private List<AdventureNumParam.AdvCond> mAdvCondList;

    [Token(Token = "0x17000AC1")]
    public int AdvNum
    {
      [Token(Token = "0x60067FD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AC2")]
    public List<AdventureNumParam.AdvCond> AdvCondList
    {
      [Token(Token = "0x60067FE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<AdventureNumParam.AdvCond>) null;
      }
    }

    [Token(Token = "0x60067FF")]
    [Address(RVA = "0x31E490", Offset = "0x31D290", VA = "0x1031E490")]
    public void Deserialize(JSON_AdventureNumParam json)
    {
    }

    [Token(Token = "0x6006800")]
    [Address(RVA = "0x31E5A0", Offset = "0x31D3A0", VA = "0x1031E5A0")]
    public static void Deserialize(ref AdventureNumParam param, JSON_AdventureNumParam[] json)
    {
    }

    [Token(Token = "0x6006801")]
    [Address(RVA = "0x31E790", Offset = "0x31D590", VA = "0x1031E790")]
    public static AdventureNumParam GetParam() => (AdventureNumParam) null;

    [Token(Token = "0x6006802")]
    [Address(RVA = "0x31E810", Offset = "0x31D610", VA = "0x1031E810")]
    public AdventureNumParam()
    {
    }

    [Token(Token = "0x2001983")]
    public class AdvCond
    {
      [Token(Token = "0x4005CEA")]
      [FieldOffset(Offset = "0x8")]
      private int mAdvAdd;
      [Token(Token = "0x4005CEB")]
      [FieldOffset(Offset = "0xC")]
      private int mClearNum;

      [Token(Token = "0x17000AC3")]
      public int AdvAdd
      {
        [Token(Token = "0x6006803"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000AC4")]
      public int ClearNum
      {
        [Token(Token = "0x6006804"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6006805")]
      [Address(RVA = "0x319840", Offset = "0x318640", VA = "0x10319840")]
      public void Deserialize(JSON_AdventureNumParam.AdvCond json)
      {
      }

      [Token(Token = "0x6006806")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AdvCond()
      {
      }
    }
  }
}
