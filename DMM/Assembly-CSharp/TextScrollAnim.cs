// Decompiled with JetBrains decompiler
// Type: TextScrollAnim
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002DD")]
[AddComponentMenu("UI/TextScrollAnim")]
public class TextScrollAnim : MonoBehaviour
{
  [Token(Token = "0x4000BDB")]
  [FieldOffset(Offset = "0xC")]
  public float MoveSpeed;
  [Token(Token = "0x4000BDC")]
  [FieldOffset(Offset = "0x10")]
  public float ResetSpeed;
  [Token(Token = "0x4000BDD")]
  [FieldOffset(Offset = "0x14")]
  public float ResetWaitTime;
  [Token(Token = "0x4000BDE")]
  [FieldOffset(Offset = "0x18")]
  public float mStopTime;
  [Token(Token = "0x4000BDF")]
  [FieldOffset(Offset = "0x1C")]
  private Vector3 mPrePosition;
  [Token(Token = "0x4000BE0")]
  [FieldOffset(Offset = "0x28")]
  private Vector3 mBasePosition;
  [Token(Token = "0x4000BE1")]
  [FieldOffset(Offset = "0x34")]
  private RectTransform rectTrans;
  [Token(Token = "0x4000BE2")]
  [FieldOffset(Offset = "0x38")]
  private float mParentWidth;
  [Token(Token = "0x4000BE3")]
  [FieldOffset(Offset = "0x3C")]
  private float mTextWidth;
  [Token(Token = "0x4000BE4")]
  [FieldOffset(Offset = "0x40")]
  private string mPreText;
  [Token(Token = "0x4000BE5")]
  [FieldOffset(Offset = "0x44")]
  private TextScrollAnim.State mState;

  [Token(Token = "0x6000EE9")]
  [Address(RVA = "0x11DBA90", Offset = "0x11DA890", VA = "0x111DBA90")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EEA")]
  [Address(RVA = "0x11DBC10", Offset = "0x11DAA10", VA = "0x111DBC10")]
  private void Update()
  {
  }

  [Token(Token = "0x6000EEB")]
  [Address(RVA = "0x11DB5D0", Offset = "0x11DA3D0", VA = "0x111DB5D0")]
  private bool IsTextChangeCheck() => new bool();

  [Token(Token = "0x6000EEC")]
  [Address(RVA = "0x11DBF80", Offset = "0x11DAD80", VA = "0x111DBF80")]
  private void WaitInAnim()
  {
  }

  [Token(Token = "0x6000EED")]
  [Address(RVA = "0x11DB970", Offset = "0x11DA770", VA = "0x111DB970")]
  private void StartCheck()
  {
  }

  [Token(Token = "0x6000EEE")]
  [Address(RVA = "0x11DB6F0", Offset = "0x11DA4F0", VA = "0x111DB6F0")]
  private void MoveAnim()
  {
  }

  [Token(Token = "0x6000EEF")]
  [Address(RVA = "0x11DB820", Offset = "0x11DA620", VA = "0x111DB820")]
  private void ResetAnim()
  {
  }

  [Token(Token = "0x6000EF0")]
  [Address(RVA = "0x11DB950", Offset = "0x11DA750", VA = "0x111DB950")]
  public void Reset()
  {
  }

  [Token(Token = "0x6000EF1")]
  [Address(RVA = "0x11DBF40", Offset = "0x11DAD40", VA = "0x111DBF40")]
  private void WaitAnim()
  {
  }

  [Token(Token = "0x6000EF2")]
  [Address(RVA = "0x11DC050", Offset = "0x11DAE50", VA = "0x111DC050")]
  public TextScrollAnim()
  {
  }

  [Token(Token = "0x20002DE")]
  private enum State
  {
    [Token(Token = "0x4000BE7")] NONE,
    [Token(Token = "0x4000BE8")] INANIM_WAIT,
    [Token(Token = "0x4000BE9")] START_CHECK,
    [Token(Token = "0x4000BEA")] MOVE_ANIM,
    [Token(Token = "0x4000BEB")] RESET_ANIM,
    [Token(Token = "0x4000BEC")] WAIT_ANIM,
  }
}
