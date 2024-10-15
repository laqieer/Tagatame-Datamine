// Decompiled with JetBrains decompiler
// Type: UnitVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000184")]
[AddComponentMenu("Audio/UnitVoice")]
public class UnitVoice : MonoBehaviour
{
  [Token(Token = "0x400075B")]
  [FieldOffset(Offset = "0xC")]
  public UnitVoice.ECharType CharType;
  [Token(Token = "0x400075C")]
  [FieldOffset(Offset = "0x10")]
  public string DirectCharName;
  [Token(Token = "0x400075D")]
  [FieldOffset(Offset = "0x14")]
  public string DirectSkinName;
  [Token(Token = "0x400075E")]
  [FieldOffset(Offset = "0x18")]
  public string CueName;
  [Token(Token = "0x400075F")]
  [FieldOffset(Offset = "0x1C")]
  public bool PlayOnAwake;
  [Token(Token = "0x4000760")]
  [FieldOffset(Offset = "0x20")]
  public UnitVoice.eCollaboType CollaboType;
  [Token(Token = "0x4000761")]
  [FieldOffset(Offset = "0x24")]
  private bool mPlayAutomatic;
  [Token(Token = "0x4000762")]
  [FieldOffset(Offset = "0x28")]
  private string mCharName;
  [Token(Token = "0x4000763")]
  [FieldOffset(Offset = "0x2C")]
  private string mSkinName;
  [Token(Token = "0x4000764")]
  [FieldOffset(Offset = "0x30")]
  private string mCueName;
  [Token(Token = "0x4000765")]
  [FieldOffset(Offset = "0x34")]
  private MySound.Voice mVoice;

  [Token(Token = "0x600099F")]
  [Address(RVA = "0xF541C0", Offset = "0xF52FC0", VA = "0x10F541C0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60009A0")]
  [Address(RVA = "0xF541B0", Offset = "0xF52FB0", VA = "0x10F541B0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60009A1")]
  [Address(RVA = "0xF54110", Offset = "0xF52F10", VA = "0x10F54110")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009A2")]
  [Address(RVA = "0xF54C10", Offset = "0xF53A10", VA = "0x10F54C10")]
  private void Update()
  {
  }

  [Token(Token = "0x60009A3")]
  [Address(RVA = "0xF54260", Offset = "0xF53060", VA = "0x10F54260")]
  public void SearchUnitSkinVoiceName(ref string sheetName, ref string cueName)
  {
  }

  [Token(Token = "0x60009A4")]
  [Address(RVA = "0xF54170", Offset = "0xF52F70", VA = "0x10F54170")]
  public void GetDefaultCharName(ref string directName, ref string sheetName, ref string cueName)
  {
  }

  [Token(Token = "0x60009A5")]
  [Address(RVA = "0xF546D0", Offset = "0xF534D0", VA = "0x10F546D0")]
  public bool SetCharName(string directName, string sheetName, string cueName) => new bool();

  [Token(Token = "0x60009A6")]
  [Address(RVA = "0xF54BC0", Offset = "0xF539C0", VA = "0x10F54BC0")]
  public bool SetupCueName() => new bool();

  [Token(Token = "0x60009A7")]
  [Address(RVA = "0xF54230", Offset = "0xF53030", VA = "0x10F54230")]
  public void Play()
  {
  }

  [Token(Token = "0x60009A8")]
  [Address(RVA = "0xF54110", Offset = "0xF52F10", VA = "0x10F54110")]
  public void Discard()
  {
  }

  [Token(Token = "0x60009A9")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UnitVoice()
  {
  }

  [Token(Token = "0x2000185")]
  public enum ECharType
  {
    [Token(Token = "0x4000767")] AUTO,
    [Token(Token = "0x4000768")] DIRECT_CHAR_NAME,
    [Token(Token = "0x4000769")] BATTLE_SKILL,
    [Token(Token = "0x400076A")] BATTLE_SKILL_COLLABO,
  }

  [Token(Token = "0x2000186")]
  public enum eCollaboType
  {
    [Token(Token = "0x400076C")] MAIN,
    [Token(Token = "0x400076D")] SUB,
  }
}
