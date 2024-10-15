// Decompiled with JetBrains decompiler
// Type: SRPG.ExtraQuestClearElementProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C58")]
  public class ExtraQuestClearElementProgress
  {
    [Token(Token = "0x4006F55")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006F56")]
    [FieldOffset(Offset = "0xC")]
    private List<TrophyConditionTypes> mTypes;

    [Token(Token = "0x17000EEC")]
    public string Iname
    {
      [Token(Token = "0x600750A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000EED")]
    public List<TrophyConditionTypes> Types
    {
      [Token(Token = "0x600750B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<TrophyConditionTypes>) null;
      }
    }

    [Token(Token = "0x600750C")]
    [Address(RVA = "0x38FB40", Offset = "0x38E940", VA = "0x1038FB40")]
    public bool Deserialize(JSON_ExtraQuestClearElementProgress json) => new bool();

    [Token(Token = "0x600750D")]
    [Address(RVA = "0x38FC30", Offset = "0x38EA30", VA = "0x1038FC30")]
    public ExtraQuestClearElementProgress()
    {
    }
  }
}
