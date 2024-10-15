// Decompiled with JetBrains decompiler
// Type: EventQuit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[Token(Token = "0x20002A2")]
[AddComponentMenu("UI/EventQuit")]
public class EventQuit : MonoBehaviour
{
  [Token(Token = "0x170001B1")]
  private static EventQuit Instance
  {
    [Token(Token = "0x6000E05"), Address(RVA = "0x11CEAF0", Offset = "0x11CD8F0", VA = "0x111CEAF0")] get
    {
      return (EventQuit) null;
    }
    [Token(Token = "0x6000E06"), Address(RVA = "0x11CEB20", Offset = "0x11CD920", VA = "0x111CEB20")] set
    {
    }
  }

  [Token(Token = "0x6000E07")]
  [Address(RVA = "0x11CE9A0", Offset = "0x11CD7A0", VA = "0x111CE9A0")]
  public static EventQuit Find() => (EventQuit) null;

  [Token(Token = "0x170001B2")]
  public UnityAction OnClick
  {
    [Token(Token = "0x6000E08"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] private get
    {
      return (UnityAction) null;
    }
    [Token(Token = "0x6000E09"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
    {
    }
  }

  [Token(Token = "0x6000E0A")]
  [Address(RVA = "0x11CEA80", Offset = "0x11CD880", VA = "0x111CEA80")]
  public void Quit()
  {
  }

  [Token(Token = "0x6000E0B")]
  [Address(RVA = "0x11CE8D0", Offset = "0x11CD6D0", VA = "0x111CE8D0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000E0C")]
  [Address(RVA = "0x11CE9D0", Offset = "0x11CD7D0", VA = "0x111CE9D0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000E0D")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E0E")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public EventQuit()
  {
  }
}
