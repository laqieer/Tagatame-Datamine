// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisQuestMapSymbol
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024FB")]
  [AddComponentMenu("UI/Genesis/GenesisQuestMapSymbol")]
  public class GenesisQuestMapSymbol : MonoBehaviour
  {
    [Token(Token = "0x400A8FC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenesisQuestMapIcon mRefIconObject;
    [Token(Token = "0x400A8FD")]
    [FieldOffset(Offset = "0x10")]
    private QuestParam mQuestParam;

    [Token(Token = "0x170016BA")]
    public GenesisQuestMapIcon Icon
    {
      [Token(Token = "0x600A271"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GenesisQuestMapIcon) null;
      }
    }

    [Token(Token = "0x600A272")]
    [Address(RVA = "0x648270", Offset = "0x647070", VA = "0x10648270")]
    public bool Init(
      QuestParam param,
      bool is_top,
      bool is_end,
      GenesisQuestMapIcon.OnClickIcon onclick_icon,
      GenesisQuestMapIcon.OnClickLockedIcon onclick_locked_icon)
    {
      return new bool();
    }

    [Token(Token = "0x600A273")]
    [Address(RVA = "0x6485B0", Offset = "0x6473B0", VA = "0x106485B0")]
    public void UpdateState()
    {
    }

    [Token(Token = "0x600A274")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisQuestMapSymbol()
    {
    }

    [Token(Token = "0x20024FC")]
    public enum eQuestState
    {
      [Token(Token = "0x400A8FF")] INVALID,
      [Token(Token = "0x400A900")] LOCK,
      [Token(Token = "0x400A901")] PLAYABLE,
      [Token(Token = "0x400A902")] CLEARED,
    }
  }
}
