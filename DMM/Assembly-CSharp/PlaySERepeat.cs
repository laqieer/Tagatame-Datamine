// Decompiled with JetBrains decompiler
// Type: PlaySERepeat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000204")]
public class PlaySERepeat : MonoBehaviour
{
  [Token(Token = "0x40008DA")]
  [FieldOffset(Offset = "0xC")]
  private string mCueID;
  [Token(Token = "0x40008DB")]
  [FieldOffset(Offset = "0x10")]
  private float RepeatWait;
  [Token(Token = "0x40008DC")]
  [FieldOffset(Offset = "0x14")]
  private int mPlayCount;
  [Token(Token = "0x40008DD")]
  [FieldOffset(Offset = "0x18")]
  private float mRepeatWait;
  [Token(Token = "0x40008DE")]
  [FieldOffset(Offset = "0x1C")]
  private bool mStop;
  [Token(Token = "0x40008DF")]
  [FieldOffset(Offset = "0x20")]
  private float mStopSec;
  [Token(Token = "0x40008E0")]
  [FieldOffset(Offset = "0x24")]
  private float mFadeOutSec;
  [Token(Token = "0x40008E1")]
  [FieldOffset(Offset = "0x28")]
  private bool mUseCustomPlay;
  [Token(Token = "0x40008E2")]
  [FieldOffset(Offset = "0x2C")]
  private MySound.CueSheetHandle.ELoopFlag mCustomLoopFlag;
  [Token(Token = "0x40008E3")]
  [FieldOffset(Offset = "0x30")]
  private float mCustomDelaySec;
  [Token(Token = "0x40008E4")]
  [FieldOffset(Offset = "0x34")]
  private MySound.CueSheetHandle mHandle;
  [Token(Token = "0x40008E5")]
  [FieldOffset(Offset = "0x38")]
  private MySound.PlayHandle mPlayHandle;

  [Token(Token = "0x6000B4E")]
  [Address(RVA = "0x10894F0", Offset = "0x10882F0", VA = "0x110894F0")]
  public void Setup(
    string sheetName,
    string cueID,
    MySound.EType type,
    int repeatCount,
    float repeatWait,
    float stopSec,
    float fadeOutSec,
    bool useCustom,
    MySound.CueSheetHandle.ELoopFlag customLoopFlag,
    float customDelaySec)
  {
  }

  [Token(Token = "0x6000B4F")]
  [Address(RVA = "0x1089590", Offset = "0x1088390", VA = "0x11089590")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B50")]
  [Address(RVA = "0x1089450", Offset = "0x1088250", VA = "0x11089450")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B51")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public PlaySERepeat()
  {
  }
}
