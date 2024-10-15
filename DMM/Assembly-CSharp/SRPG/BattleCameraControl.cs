// Decompiled with JetBrains decompiler
// Type: SRPG.BattleCameraControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000B54")]
  [AddComponentMenu("Battle/BattleCameraControl")]
  public class BattleCameraControl : MonoBehaviour
  {
    [Token(Token = "0x4001B70")]
    [FieldOffset(Offset = "0xC")]
    public Button RotateLeft;
    [Token(Token = "0x4001B71")]
    [FieldOffset(Offset = "0x10")]
    public Button RotateRight;
    [Token(Token = "0x4001B72")]
    [FieldOffset(Offset = "0x14")]
    public Slider RotationSlider;
    [Token(Token = "0x4001B73")]
    [FieldOffset(Offset = "0x18")]
    public Scrollbar RotationScroll;
    [Token(Token = "0x4001B74")]
    [FieldOffset(Offset = "0x1C")]
    public float RotateAmount;
    [Token(Token = "0x4001B75")]
    [FieldOffset(Offset = "0x20")]
    public float RotateTime;
    [Token(Token = "0x4001B76")]
    [FieldOffset(Offset = "0x24")]
    private Animator m_Animator;
    [Token(Token = "0x4001B77")]
    [FieldOffset(Offset = "0x28")]
    private Canvas m_Canvas;
    [Token(Token = "0x4001B78")]
    [FieldOffset(Offset = "0x2C")]
    private GraphicsRaycasterExtend m_GraphicRaycatser;
    [Token(Token = "0x4001B79")]
    [FieldOffset(Offset = "0x30")]
    private bool m_Disp;

    [Token(Token = "0x6002B60")]
    [Address(RVA = "0xFC6EE0", Offset = "0xFC5CE0", VA = "0x10FC6EE0")]
    private void Start()
    {
    }

    [Token(Token = "0x6002B61")]
    [Address(RVA = "0xFC7130", Offset = "0xFC5F30", VA = "0x10FC7130")]
    private void Update()
    {
    }

    [Token(Token = "0x6002B62")]
    [Address(RVA = "0xFC6D10", Offset = "0xFC5B10", VA = "0x10FC6D10")]
    private void OnRotateLeft()
    {
    }

    [Token(Token = "0x6002B63")]
    [Address(RVA = "0xFC6D90", Offset = "0xFC5B90", VA = "0x10FC6D90")]
    private void OnRotateRight()
    {
    }

    [Token(Token = "0x6002B64")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnRotationValueChange(float value)
    {
    }

    [Token(Token = "0x6002B65")]
    [Address(RVA = "0xFC6E00", Offset = "0xFC5C00", VA = "0x10FC6E00")]
    public void SetDisp(bool value)
    {
    }

    [Token(Token = "0x6002B66")]
    [Address(RVA = "0xFC6BF0", Offset = "0xFC59F0", VA = "0x10FC6BF0")]
    public void OnEventCall(string key, string value)
    {
    }

    [Token(Token = "0x6002B67")]
    [Address(RVA = "0xFC7440", Offset = "0xFC6240", VA = "0x10FC7440")]
    public BattleCameraControl()
    {
    }
  }
}
