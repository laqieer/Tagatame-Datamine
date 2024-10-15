// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureLocalNotification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F8C")]
  public class AdventureLocalNotification
  {
    [Token(Token = "0x400853E")]
    [FieldOffset(Offset = "0x8")]
    private AdventureLocalNotification.SaveData mData;

    [Token(Token = "0x600819B")]
    [Address(RVA = "0x423E40", Offset = "0x422C40", VA = "0x10423E40")]
    public AdventureLocalNotification()
    {
    }

    [Token(Token = "0x600819C")]
    [Address(RVA = "0x423940", Offset = "0x422740", VA = "0x10423940")]
    private void Load()
    {
    }

    [Token(Token = "0x600819D")]
    [Address(RVA = "0x423DB0", Offset = "0x422BB0", VA = "0x10423DB0")]
    private void Save()
    {
    }

    [Token(Token = "0x600819E")]
    [Address(RVA = "0x423780", Offset = "0x422580", VA = "0x10423780")]
    public void AddList(string _iname)
    {
    }

    [Token(Token = "0x600819F")]
    [Address(RVA = "0x423CB0", Offset = "0x422AB0", VA = "0x10423CB0")]
    public void RemoveList(string _iname)
    {
    }

    [Token(Token = "0x60081A0")]
    [Address(RVA = "0x423A90", Offset = "0x422890", VA = "0x10423A90")]
    public void RemoveListRenge(List<string> _iname_list)
    {
    }

    [Token(Token = "0x60081A1")]
    [Address(RVA = "0x423880", Offset = "0x422680", VA = "0x10423880")]
    public bool IsReservation(string _iname) => new bool();

    [Token(Token = "0x60081A2")]
    [Address(RVA = "0x423A30", Offset = "0x422830", VA = "0x10423A30")]
    public void RemoveAll()
    {
    }

    [Token(Token = "0x2001F8D")]
    [Serializable]
    private struct SaveData
    {
      [Token(Token = "0x400853F")]
      [FieldOffset(Offset = "0x0")]
      public List<string> area_inames;
    }
  }
}
