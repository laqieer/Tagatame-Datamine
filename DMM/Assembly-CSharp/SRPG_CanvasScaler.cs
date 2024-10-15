// Decompiled with JetBrains decompiler
// Type: SRPG_CanvasScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002D4")]
[AddComponentMenu("Layout/Canvas Scaler (SRPG)")]
[ExecuteInEditMode]
public class SRPG_CanvasScaler : CanvasScaler
{
  [Token(Token = "0x4000BBE")]
  [FieldOffset(Offset = "0x0")]
  public static bool UseKuroObi;
  [Token(Token = "0x4000BBF")]
  public const float MinScreenWidth = 1334f;
  [Token(Token = "0x4000BC0")]
  public const float MinScreenHeight = 750f;

  [Token(Token = "0x6000EC5")]
  [Address(RVA = "0x11D74D0", Offset = "0x11D62D0", VA = "0x111D74D0", Slot = "4")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000EC6")]
  [Address(RVA = "0x11D75A0", Offset = "0x11D63A0", VA = "0x111D75A0")]
  public SRPG_CanvasScaler()
  {
  }

  [Token(Token = "0x6000EC7")]
  [Address(RVA = "0x11D7570", Offset = "0x11D6370", VA = "0x111D7570")]
  static SRPG_CanvasScaler()
  {
  }
}
