// Decompiled with JetBrains decompiler
// Type: UIDeactivator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002E5")]
[AddComponentMenu("UI/UIDeactivator")]
public class UIDeactivator : MonoBehaviour
{
  [Token(Token = "0x4000C1E")]
  [FieldOffset(Offset = "0x10")]
  private float mCountDown;

  [Token(Token = "0x170001CF")]
  public string keyname
  {
    [Token(Token = "0x6000F07"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000F08"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
    {
    }
  }

  [Token(Token = "0x6000F09")]
  [Address(RVA = "0x12A7100", Offset = "0x12A5F00", VA = "0x112A7100")]
  public UIDeactivator()
  {
  }

  [Token(Token = "0x6000F0A")]
  [Address(RVA = "0x12A70F0", Offset = "0x12A5EF0", VA = "0x112A70F0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000F0B")]
  [Address(RVA = "0x12A70F0", Offset = "0x12A5EF0", VA = "0x112A70F0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000F0C")]
  [Address(RVA = "0x12A6F00", Offset = "0x12A5D00", VA = "0x112A6F00")]
  private void LateUpdate()
  {
  }
}
