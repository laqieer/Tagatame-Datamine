// Decompiled with JetBrains decompiler
// Type: SRPG.UnlockCharacterQuestPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D2D")]
  [AddComponentMenu("UI/UnlockCharacterQuestPopup")]
  public class UnlockCharacterQuestPopup : MonoBehaviour
  {
    [Token(Token = "0x400E131")]
    [FieldOffset(Offset = "0xC")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400E132")]
    [FieldOffset(Offset = "0x10")]
    public Text EpisodeTitle;
    [Token(Token = "0x400E133")]
    [FieldOffset(Offset = "0x14")]
    public Text EpisodeNumber;

    [Token(Token = "0x600D284")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D285")]
    [Address(RVA = "0x9DA0B0", Offset = "0x9D8EB0", VA = "0x109DA0B0")]
    public void Setup(UnitData unit, int episodeNumber, string episodeTitle)
    {
    }

    [Token(Token = "0x600D286")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnlockCharacterQuestPopup()
    {
    }
  }
}
