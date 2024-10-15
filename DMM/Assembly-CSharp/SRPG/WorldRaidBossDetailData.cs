// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D5D")]
  public class WorldRaidBossDetailData : WorldRaidBossData
  {
    [Token(Token = "0x17001BA8")]
    public List<string> SelectedUnitInameList
    {
      [Token(Token = "0x600D34E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x600D34F"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x600D350")]
    [Address(RVA = "0x9E2160", Offset = "0x9E0F60", VA = "0x109E2160")]
    public WorldRaidBossDetailData()
    {
    }

    [Token(Token = "0x600D351")]
    [Address(RVA = "0x9E2080", Offset = "0x9E0E80", VA = "0x109E2080")]
    public bool Deserialize(JSON_WorldRaidBossDetailData json) => new bool();
  }
}
