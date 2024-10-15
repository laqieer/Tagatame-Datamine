// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceQuestMapSymbol
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F62")]
  [AddComponentMenu("UI/Advance/AdvanceQuestMapSymbol")]
  public class AdvanceQuestMapSymbol : MonoBehaviour
  {
    [Token(Token = "0x400845A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private AdvanceQuestMapIcon mRefIconObject;
    [Token(Token = "0x400845B")]
    [FieldOffset(Offset = "0x10")]
    private QuestParam mQuestParam;

    [Token(Token = "0x17001275")]
    public AdvanceQuestMapIcon Icon
    {
      [Token(Token = "0x60080D2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AdvanceQuestMapIcon) null;
      }
    }

    [Token(Token = "0x60080D3")]
    [Address(RVA = "0x416B70", Offset = "0x415970", VA = "0x10416B70")]
    public bool Init(
      QuestParam param,
      bool is_top,
      bool is_end,
      AdvanceQuestMapIcon.OnClickIcon onclick_icon,
      AdvanceQuestMapIcon.OnClickLockedIcon onclick_locked_icon)
    {
      return new bool();
    }

    [Token(Token = "0x60080D4")]
    [Address(RVA = "0x416EB0", Offset = "0x415CB0", VA = "0x10416EB0")]
    public void UpdateState()
    {
    }

    [Token(Token = "0x60080D5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceQuestMapSymbol()
    {
    }

    [Token(Token = "0x2001F63")]
    public enum eQuestState
    {
      [Token(Token = "0x400845D")] INVALID,
      [Token(Token = "0x400845E")] LOCK,
      [Token(Token = "0x400845F")] PLAYABLE,
      [Token(Token = "0x4008460")] CLEARED,
    }
  }
}
