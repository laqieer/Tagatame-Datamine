// Decompiled with JetBrains decompiler
// Type: SRPG.Tooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001172")]
  [AddComponentMenu("Common/Tooltip")]
  public class Tooltip : MonoBehaviour
  {
    [Token(Token = "0x4003F0E")]
    [FieldOffset(Offset = "0x0")]
    public static Vector2 TooltipPosition;
    [Token(Token = "0x4003F0F")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform Body;
    [Token(Token = "0x4003F10")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform SizeBody;
    [Token(Token = "0x4003F11")]
    [FieldOffset(Offset = "0x14")]
    public Text TooltipText;
    [Token(Token = "0x4003F12")]
    [FieldOffset(Offset = "0x18")]
    public Text TextName;
    [Token(Token = "0x4003F13")]
    [FieldOffset(Offset = "0x1C")]
    public Text TextDesc;
    [Token(Token = "0x4003F14")]
    [FieldOffset(Offset = "0x20")]
    public string CloseTrigger;
    [Token(Token = "0x4003F15")]
    [FieldOffset(Offset = "0x24")]
    public float DestroyDelay;
    [Token(Token = "0x4003F16")]
    [FieldOffset(Offset = "0x28")]
    private Animator mAnimator;
    [Token(Token = "0x4003F17")]
    [FieldOffset(Offset = "0x2C")]
    private bool mDestroying;
    [Token(Token = "0x4003F18")]
    [FieldOffset(Offset = "0x2D")]
    public bool CloseOnPress;

    [Token(Token = "0x6004A63")]
    [Address(RVA = "0x120B3B0", Offset = "0x120A1B0", VA = "0x1120B3B0")]
    public static void SetTooltipPosition(RectTransform rect, Vector2 localPos)
    {
    }

    [Token(Token = "0x6004A64")]
    [Address(RVA = "0x120B260", Offset = "0x120A060", VA = "0x1120B260")]
    public void ResetPosition()
    {
    }

    [Token(Token = "0x17000821")]
    public Vector2 BodySize
    {
      [Token(Token = "0x6004A65"), Address(RVA = "0x120B760", Offset = "0x120A560", VA = "0x1120B760")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17000822")]
    public bool EnableDisp
    {
      [Token(Token = "0x6004A66"), Address(RVA = "0x120B810", Offset = "0x120A610", VA = "0x1120B810")] set
      {
      }
    }

    [Token(Token = "0x6004A67")]
    [Address(RVA = "0x120B560", Offset = "0x120A360", VA = "0x1120B560")]
    private void Start()
    {
    }

    [Token(Token = "0x6004A68")]
    [Address(RVA = "0x120B140", Offset = "0x1209F40", VA = "0x1120B140")]
    public void Close()
    {
    }

    [Token(Token = "0x6004A69")]
    [Address(RVA = "0x120B6E0", Offset = "0x120A4E0", VA = "0x1120B6E0")]
    private void Update()
    {
    }

    [Token(Token = "0x6004A6A")]
    [Address(RVA = "0x120B4E0", Offset = "0x120A2E0", VA = "0x1120B4E0")]
    public void SetTooltipText(string value)
    {
    }

    [Token(Token = "0x6004A6B")]
    [Address(RVA = "0x840150", Offset = "0x83EF50", VA = "0x10840150")]
    public Tooltip()
    {
    }
  }
}
