// Decompiled with JetBrains decompiler
// Type: Win_Btn_YN_Title_Flx_Check
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000311")]
[AddComponentMenu("UI/Drafts/Win_Btn_YN_Title_Flx_Check")]
public class Win_Btn_YN_Title_Flx_Check : MonoBehaviour
{
  [Token(Token = "0x4000CA0")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  public Text Text_Title;
  [Token(Token = "0x4000CA1")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  public Text Text_Message;
  [Token(Token = "0x4000CA2")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  public Button Btn_No;
  [Token(Token = "0x4000CA3")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public Button Btn_Yes;
  [Token(Token = "0x4000CA4")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  public Toggle Toggle_Check;
  [Token(Token = "0x4000CA5")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  public Text Txt_No;
  [Token(Token = "0x4000CA6")]
  [FieldOffset(Offset = "0x24")]
  [SerializeField]
  public Text Txt_Yes;
  [Token(Token = "0x4000CA7")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  public Text Txt_Check;
  [Token(Token = "0x4000CA8")]
  [FieldOffset(Offset = "0x2C")]
  public UIUtility.DialogResultEvent OnClickYes;
  [Token(Token = "0x4000CA9")]
  [FieldOffset(Offset = "0x30")]
  public UIUtility.DialogResultEvent OnClickNo;

  [Token(Token = "0x6000FF2")]
  [Address(RVA = "0x12B26B0", Offset = "0x12B14B0", VA = "0x112B26B0")]
  private void OnWindowClose(UIWindow window)
  {
  }

  [Token(Token = "0x6000FF3")]
  [Address(RVA = "0x12B24A0", Offset = "0x12B12A0", VA = "0x112B24A0")]
  public void BeginClose()
  {
  }

  [Token(Token = "0x6000FF4")]
  [Address(RVA = "0x12B2540", Offset = "0x12B1340", VA = "0x112B2540")]
  private void OnClickButton(GameObject obj)
  {
  }

  [Token(Token = "0x6000FF5")]
  [Address(RVA = "0x12B2660", Offset = "0x12B1460", VA = "0x112B2660")]
  private void OnValueChanged(bool isOn)
  {
  }

  [Token(Token = "0x6000FF6")]
  [Address(RVA = "0x12B22E0", Offset = "0x12B10E0", VA = "0x112B22E0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000FF7")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public Win_Btn_YN_Title_Flx_Check()
  {
  }
}
