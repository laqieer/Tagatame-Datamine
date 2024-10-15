// Decompiled with JetBrains decompiler
// Type: EventBackGround
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200029D")]
[AddComponentMenu("UI/EventBackGround")]
public class EventBackGround : MonoBehaviour
{
  [Token(Token = "0x4000ADE")]
  [FieldOffset(Offset = "0x0")]
  public static List<EventBackGround> Instances;
  [Token(Token = "0x4000ADF")]
  [FieldOffset(Offset = "0xC")]
  public bool mClose;

  [Token(Token = "0x6000DED")]
  [Address(RVA = "0x11CDD80", Offset = "0x11CCB80", VA = "0x111CDD80")]
  public static EventBackGround Find() => (EventBackGround) null;

  [Token(Token = "0x6000DEE")]
  [Address(RVA = "0x11CDB80", Offset = "0x11CC980", VA = "0x111CDB80")]
  public static void DiscardAll()
  {
  }

  [Token(Token = "0x6000DEF")]
  [Address(RVA = "0x11CDAE0", Offset = "0x11CC8E0", VA = "0x111CDAE0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000DF0")]
  [Address(RVA = "0x11CDF20", Offset = "0x11CCD20", VA = "0x111CDF20")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000DF1")]
  [Address(RVA = "0x11CE010", Offset = "0x11CCE10", VA = "0x111CE010")]
  public void Open()
  {
  }

  [Token(Token = "0x6000DF2")]
  [Address(RVA = "0x11CDB50", Offset = "0x11CC950", VA = "0x111CDB50")]
  public void Close()
  {
  }

  [Token(Token = "0x6000DF3")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public EventBackGround()
  {
  }

  [Token(Token = "0x6000DF4")]
  [Address(RVA = "0x11CE040", Offset = "0x11CCE40", VA = "0x111CE040")]
  static EventBackGround()
  {
  }
}
