// Decompiled with JetBrains decompiler
// Type: SRPG.UnitRentalNotificationDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E96")]
  public class UnitRentalNotificationDataParam
  {
    [Token(Token = "0x4007FD5")]
    [FieldOffset(Offset = "0x8")]
    private int[] mPers;
    [Token(Token = "0x4007FD6")]
    [FieldOffset(Offset = "0xC")]
    private string mSysId;

    [Token(Token = "0x17001186")]
    public List<int> PerList
    {
      [Token(Token = "0x6007D72"), Address(RVA = "0x3F5310", Offset = "0x3F4110", VA = "0x103F5310")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001187")]
    public string SysId
    {
      [Token(Token = "0x6007D73"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007D74")]
    [Address(RVA = "0x3F5260", Offset = "0x3F4060", VA = "0x103F5260")]
    public void Deserialize(JSON_UnitRentalNotificationDataParam json)
    {
    }

    [Token(Token = "0x6007D75")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitRentalNotificationDataParam()
    {
    }
  }
}
