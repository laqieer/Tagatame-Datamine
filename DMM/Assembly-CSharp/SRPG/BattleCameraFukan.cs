// Decompiled with JetBrains decompiler
// Type: SRPG.BattleCameraFukan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000B55")]
  [AddComponentMenu("Battle/BattleCameraFukan")]
  public class BattleCameraFukan : MonoBehaviour
  {
    [Token(Token = "0x4001B7A")]
    [FieldOffset(Offset = "0xC")]
    public BattleCameraControl BattleCameraControl;
    [Token(Token = "0x4001B7B")]
    [FieldOffset(Offset = "0x10")]
    public GameObject DefaultButton;
    [Token(Token = "0x4001B7C")]
    [FieldOffset(Offset = "0x14")]
    public GameObject UpViewButton;
    [Token(Token = "0x4001B7D")]
    [FieldOffset(Offset = "0x18")]
    private bool m_Disp;

    [Token(Token = "0x17000220")]
    public bool isDisp
    {
      [Token(Token = "0x6002B68"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002B69")]
    [Address(RVA = "0xFC7B70", Offset = "0xFC6970", VA = "0x10FC7B70")]
    private void Start()
    {
    }

    [Token(Token = "0x6002B6A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6002B6B")]
    [Address(RVA = "0xFC75A0", Offset = "0xFC63A0", VA = "0x10FC75A0")]
    private Button SetButtonEvent(GameObject go, BattleCameraFukan.ClickEvent callback)
    {
      return (Button) null;
    }

    [Token(Token = "0x6002B6C")]
    [Address(RVA = "0xFC7680", Offset = "0xFC6480", VA = "0x10FC7680")]
    public void SetCameraMode(SceneBattle.CameraMode mode)
    {
    }

    [Token(Token = "0x6002B6D")]
    [Address(RVA = "0xFC78E0", Offset = "0xFC66E0", VA = "0x10FC78E0")]
    public void SetDisp(bool value)
    {
    }

    [Token(Token = "0x6002B6E")]
    [Address(RVA = "0xFC7470", Offset = "0xFC6270", VA = "0x10FC7470")]
    private void OnClick(BattleCameraFukan.ButtonType buttonType)
    {
    }

    [Token(Token = "0x6002B6F")]
    [Address(RVA = "0xFC7520", Offset = "0xFC6320", VA = "0x10FC7520")]
    public void OnEventCall(string key, string value)
    {
    }

    [Token(Token = "0x6002B70")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BattleCameraFukan()
    {
    }

    [Token(Token = "0x2000B56")]
    private enum ButtonType
    {
      [Token(Token = "0x4001B7F")] DEFAULT,
      [Token(Token = "0x4001B80")] UPVIEW,
    }

    [Token(Token = "0x2000B57")]
    private delegate void ClickEvent();
  }
}
