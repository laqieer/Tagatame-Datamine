// Decompiled with JetBrains decompiler
// Type: LightmapLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000109")]
[AddComponentMenu("Common/LightmapLayout")]
[ExecuteInEditMode]
public class LightmapLayout : MonoBehaviour
{
  [Token(Token = "0x40004DE")]
  [FieldOffset(Offset = "0xC")]
  public int Index;
  [Token(Token = "0x40004DF")]
  [FieldOffset(Offset = "0x10")]
  public Vector4 Position;
  [Token(Token = "0x40004E0")]
  [FieldOffset(Offset = "0x20")]
  public bool Lock;
  [Token(Token = "0x40004E1")]
  [FieldOffset(Offset = "0x24")]
  public float Scale;
  [Token(Token = "0x40004E2")]
  [FieldOffset(Offset = "0x28")]
  public Texture2D Tex;
  [Token(Token = "0x40004E3")]
  [FieldOffset(Offset = "0x2C")]
  private MaterialPropertyBlock mMaterialProperty;

  [Token(Token = "0x60006C4")]
  [Address(RVA = "0xD5B150", Offset = "0xD59F50", VA = "0x10D5B150")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006C5")]
  [Address(RVA = "0xD5B2B0", Offset = "0xD5A0B0", VA = "0x10D5B2B0")]
  private void UpdateMaterialBlock()
  {
  }

  [Token(Token = "0x60006C6")]
  [Address(RVA = "0xD5B2A0", Offset = "0xD5A0A0", VA = "0x10D5B2A0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006C7")]
  [Address(RVA = "0xD5B200", Offset = "0xD5A000", VA = "0x10D5B200")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60006C8")]
  [Address(RVA = "0xD5B150", Offset = "0xD59F50", VA = "0x10D5B150")]
  public void ApplyLayout()
  {
  }

  [Token(Token = "0x1700010F")]
  public Vector4 lightmapTilingOffset
  {
    [Token(Token = "0x60006C9"), Address(RVA = "0xAC5D20", Offset = "0xAC4B20", VA = "0x10AC5D20")] get
    {
      return new Vector4();
    }
  }

  [Token(Token = "0x17000110")]
  public int lightmapIndex
  {
    [Token(Token = "0x60006CA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x60006CB")]
  [Address(RVA = "0x840150", Offset = "0x83EF50", VA = "0x10840150")]
  public LightmapLayout()
  {
  }
}
