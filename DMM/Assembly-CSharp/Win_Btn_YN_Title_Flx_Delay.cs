// Decompiled with JetBrains decompiler
// Type: Win_Btn_YN_Title_Flx_Delay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000312")]
[AddComponentMenu("UI/Drafts/Win_Btn_YN_Title_Flx_Delay")]
public class Win_Btn_YN_Title_Flx_Delay : MonoBehaviour
{
  [Token(Token = "0x4000CAA")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  public Text Text_Title;
  [Token(Token = "0x4000CAB")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  public Text Text_Message;
  [Token(Token = "0x4000CAC")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  public Button Btn_No;
  [Token(Token = "0x4000CAD")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public Button Btn_Yes;
  [Token(Token = "0x4000CAE")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  public Text Txt_No;
  [Token(Token = "0x4000CAF")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  public Text Txt_Yes;
  [Token(Token = "0x4000CB0")]
  [FieldOffset(Offset = "0x24")]
  private float YesDelay;
  [Token(Token = "0x4000CB1")]
  [FieldOffset(Offset = "0x28")]
  private float NoDelay;
  [Token(Token = "0x4000CB2")]
  [FieldOffset(Offset = "0x2C")]
  public UIUtility.DialogResultEvent OnClickYes;
  [Token(Token = "0x4000CB3")]
  [FieldOffset(Offset = "0x30")]
  public UIUtility.DialogResultEvent OnClickNo;

  [Token(Token = "0x6000FF8")]
  [Address(RVA = "0x12B29E0", Offset = "0x12B17E0", VA = "0x112B29E0")]
  private void OnWindowClose(UIWindow window)
  {
  }

  [Token(Token = "0x6000FF9")]
  [Address(RVA = "0x12B2820", Offset = "0x12B1620", VA = "0x112B2820")]
  public void BeginClose()
  {
  }

  [Token(Token = "0x6000FFA")]
  [Address(RVA = "0x12B28C0", Offset = "0x12B16C0", VA = "0x112B28C0")]
  private void OnClickButton(GameObject obj)
  {
  }

  [Token(Token = "0x6000FFB")]
  [Address(RVA = "0x12B2A60", Offset = "0x12B1860", VA = "0x112B2A60")]
  public void SetDelay(float yesDelay, float noDelay)
  {
  }

  [Token(Token = "0x6000FFC")]
  [Address(RVA = "0x12B2AF0", Offset = "0x12B18F0", VA = "0x112B2AF0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000FFD")]
  [Address(RVA = "0x12B2730", Offset = "0x12B1530", VA = "0x112B2730")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000FFE")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public Win_Btn_YN_Title_Flx_Delay()
  {
  }
}
