﻿// Decompiled with JetBrains decompiler
// Type: Win_Btn_YN_Title_Flx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000310")]
[AddComponentMenu("UI/Drafts/Win_Btn_YN_Title_Flx")]
public class Win_Btn_YN_Title_Flx : UIDraft
{
  [Token(Token = "0x4000C98")]
  [FieldOffset(Offset = "0xC")]
  [UIDraft.AutoGenerated]
  public Text Text_Title;
  [Token(Token = "0x4000C99")]
  [FieldOffset(Offset = "0x10")]
  [UIDraft.AutoGenerated]
  public Text Text_Message;
  [Token(Token = "0x4000C9A")]
  [FieldOffset(Offset = "0x14")]
  [UIDraft.AutoGenerated]
  public Button Btn_No;
  [Token(Token = "0x4000C9B")]
  [FieldOffset(Offset = "0x18")]
  [UIDraft.AutoGenerated]
  public Button Btn_Yes;
  [Token(Token = "0x4000C9C")]
  [FieldOffset(Offset = "0x1C")]
  public Text Txt_No;
  [Token(Token = "0x4000C9D")]
  [FieldOffset(Offset = "0x20")]
  public Text Txt_Yes;
  [Token(Token = "0x4000C9E")]
  [FieldOffset(Offset = "0x24")]
  public UIUtility.DialogResultEvent OnClickYes;
  [Token(Token = "0x4000C9F")]
  [FieldOffset(Offset = "0x28")]
  public UIUtility.DialogResultEvent OnClickNo;

  [Token(Token = "0x6000FED")]
  [Address(RVA = "0x12B2D00", Offset = "0x12B1B00", VA = "0x112B2D00")]
  private void OnWindowClose(UIWindow window)
  {
  }

  [Token(Token = "0x6000FEE")]
  [Address(RVA = "0x12B2240", Offset = "0x12B1040", VA = "0x112B2240")]
  public void BeginClose()
  {
  }

  [Token(Token = "0x6000FEF")]
  [Address(RVA = "0x12B2BE0", Offset = "0x12B19E0", VA = "0x112B2BE0")]
  private void OnClickButton(GameObject obj)
  {
  }

  [Token(Token = "0x6000FF0")]
  [Address(RVA = "0x12B2150", Offset = "0x12B0F50", VA = "0x112B2150")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000FF1")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public Win_Btn_YN_Title_Flx()
  {
  }
}