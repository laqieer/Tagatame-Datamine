// Decompiled with JetBrains decompiler
// Type: SRPG.SupportList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B0D")]
  public class SupportList : UnitListV2
  {
    [Token(Token = "0x400D217")]
    [FieldOffset(Offset = "0x160")]
    public RectTransform UnitListHilit;

    [Token(Token = "0x17001A2F")]
    private List<UnitData> mOwnUnits
    {
      [Token(Token = "0x600C50D"), Address(RVA = "0x8DAEA0", Offset = "0x8D9CA0", VA = "0x108DAEA0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x600C50E")]
    [Address(RVA = "0x8DA980", Offset = "0x8D9780", VA = "0x108DA980", Slot = "18")]
    public override void SetData(object[] src, System.Type type)
    {
    }

    [Token(Token = "0x600C50F")]
    [Address(RVA = "0x8DA8A0", Offset = "0x8D96A0", VA = "0x108DA8A0", Slot = "26")]
    protected override void RefreshItems()
    {
    }

    [Token(Token = "0x600C510")]
    [Address(RVA = "0x8DAE50", Offset = "0x8D9C50", VA = "0x108DAE50")]
    public SupportList()
    {
    }
  }
}
