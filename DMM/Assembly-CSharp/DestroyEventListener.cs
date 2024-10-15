// Decompiled with JetBrains decompiler
// Type: DestroyEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000AD")]
[AddComponentMenu("Common/DestroyEventListener")]
public class DestroyEventListener : MonoBehaviour
{
  [Token(Token = "0x400034B")]
  [FieldOffset(Offset = "0xC")]
  public DestroyEventListener.DestroyEvent Listeners;

  [Token(Token = "0x6000422")]
  [Address(RVA = "0xB8A840", Offset = "0xB89640", VA = "0x10B8A840")]
  private void OnApplicationQuit()
  {
  }

  [Token(Token = "0x6000423")]
  [Address(RVA = "0xB8A920", Offset = "0xB89720", VA = "0x10B8A920")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000424")]
  [Address(RVA = "0xB8A950", Offset = "0xB89750", VA = "0x10B8A950")]
  public DestroyEventListener()
  {
  }

  [Token(Token = "0x20000AE")]
  public delegate void DestroyEvent(GameObject go);
}
