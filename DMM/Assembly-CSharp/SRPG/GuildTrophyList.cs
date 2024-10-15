// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrophyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B70")]
  [AddComponentMenu("UI/Trophy/GuildTrophyList")]
  public class GuildTrophyList : TrophyList
  {
    [Token(Token = "0x17001A65")]
    public override List<TrophyState> TrophyDailyData
    {
      [Token(Token = "0x600C6FF"), Address(RVA = "0x8F5D90", Offset = "0x8F4B90", VA = "0x108F5D90", Slot = "10")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A66")]
    public override List<TrophyState> TrophyEndedData
    {
      [Token(Token = "0x600C700"), Address(RVA = "0x8F5E10", Offset = "0x8F4C10", VA = "0x108F5E10", Slot = "11")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x600C701")]
    [Address(RVA = "0x8F4F00", Offset = "0x8F3D00", VA = "0x108F4F00", Slot = "12")]
    public override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C702")]
    [Address(RVA = "0x8F4FD0", Offset = "0x8F3DD0", VA = "0x108F4FD0", Slot = "13")]
    protected override void SelectGotoShortCut(TrophyParam param)
    {
    }

    [Token(Token = "0x600C703")]
    [Address(RVA = "0x8F5C50", Offset = "0x8F4A50", VA = "0x108F5C50")]
    public GuildTrophyList()
    {
    }
  }
}
