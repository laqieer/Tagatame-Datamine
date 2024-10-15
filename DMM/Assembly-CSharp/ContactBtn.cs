// Decompiled with JetBrains decompiler
// Type: ContactBtn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200029A")]
[AddComponentMenu("UI/ContactBtn")]
public class ContactBtn : MonoBehaviour
{
  [Token(Token = "0x4000AD0")]
  [FieldOffset(Offset = "0xC")]
  public ContactBtn.SubjectType Subject;

  [Token(Token = "0x6000DE6")]
  [Address(RVA = "0x11CCA80", Offset = "0x11CB880", VA = "0x111CCA80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000DE7")]
  [Address(RVA = "0x11CCA40", Offset = "0x11CB840", VA = "0x111CCA40")]
  private void OpenMailer()
  {
  }

  [Token(Token = "0x6000DE8")]
  [Address(RVA = "0x11CCBA0", Offset = "0x11CB9A0", VA = "0x111CCBA0")]
  public ContactBtn()
  {
  }

  [Token(Token = "0x200029B")]
  public enum SubjectType : byte
  {
    [Token(Token = "0x4000AD2")] DataRestore = 1,
    [Token(Token = "0x4000AD3")] BuyCoin = 2,
    [Token(Token = "0x4000AD4")] BugReport = 3,
    [Token(Token = "0x4000AD5")] FgGID = 4,
    [Token(Token = "0x4000AD6")] CommentRequest = 5,
    [Token(Token = "0x4000AD7")] Other = 6,
  }
}
