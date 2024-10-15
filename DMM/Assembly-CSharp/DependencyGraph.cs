// Decompiled with JetBrains decompiler
// Type: DependencyGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.IO;

#nullable disable
[Token(Token = "0x20000A5")]
public class DependencyGraph
{
  [Token(Token = "0x400032B")]
  [FieldOffset(Offset = "0x8")]
  public List<DependencyGraph.Node> Nodes;

  [Token(Token = "0x60003F0")]
  [Address(RVA = "0xB85E20", Offset = "0xB84C20", VA = "0x10B85E20")]
  public static string SerializeHash(int num) => (string) null;

  [Token(Token = "0x60003F1")]
  [Address(RVA = "0xB85690", Offset = "0xB84490", VA = "0x10B85690")]
  public static int DeserializeHash(string value) => new int();

  [Token(Token = "0x60003F2")]
  [Address(RVA = "0xB85A10", Offset = "0xB84810", VA = "0x10B85A10")]
  public void LoadGraphFromFile(string path)
  {
  }

  [Token(Token = "0x60003F3")]
  [Address(RVA = "0xB85B20", Offset = "0xB84920", VA = "0x10B85B20")]
  public void LoadGraphFromMemory(string src)
  {
  }

  [Token(Token = "0x60003F4")]
  [Address(RVA = "0xB85B80", Offset = "0xB84980", VA = "0x10B85B80")]
  private void LoadGraphFromStream(TextReader reader)
  {
  }

  [Token(Token = "0x60003F5")]
  [Address(RVA = "0xB856E0", Offset = "0xB844E0", VA = "0x10B856E0")]
  public DependencyGraph.Node FindNodeByName(string nodeName) => (DependencyGraph.Node) null;

  [Token(Token = "0x60003F6")]
  [Address(RVA = "0xB857D0", Offset = "0xB845D0", VA = "0x10B857D0")]
  public DependencyGraph.Node FindNode(string nodeID) => (DependencyGraph.Node) null;

  [Token(Token = "0x60003F7")]
  [Address(RVA = "0xB85880", Offset = "0xB84680", VA = "0x10B85880")]
  public DependencyGraph.Node GetNode(string nodeID) => (DependencyGraph.Node) null;

  [Token(Token = "0x60003F8")]
  [Address(RVA = "0xB85E60", Offset = "0xB84C60", VA = "0x10B85E60")]
  public DependencyGraph()
  {
  }

  [Token(Token = "0x20000A6")]
  [Flags]
  public enum NodeFlags
  {
    [Token(Token = "0x400032D")] Required = 1,
    [Token(Token = "0x400032E")] Shared = 2,
    [Token(Token = "0x400032F")] SceneAsset = 4,
    [Token(Token = "0x4000330")] SubAsset = 8,
    [Token(Token = "0x4000331")] Compressed = 16, // 0x00000010
  }

  [Token(Token = "0x20000A7")]
  public class Node
  {
    [Token(Token = "0x4000332")]
    [FieldOffset(Offset = "0x8")]
    public string UniqueID;
    [Token(Token = "0x4000333")]
    [FieldOffset(Offset = "0xC")]
    public string Path;
    [Token(Token = "0x4000334")]
    [FieldOffset(Offset = "0x10")]
    public string Name;
    [Token(Token = "0x4000335")]
    [FieldOffset(Offset = "0x14")]
    public int NameHash;
    [Token(Token = "0x4000336")]
    [FieldOffset(Offset = "0x18")]
    public int Hash;
    [Token(Token = "0x4000337")]
    [FieldOffset(Offset = "0x1C")]
    public int Size;
    [Token(Token = "0x4000338")]
    [FieldOffset(Offset = "0x20")]
    public bool IsRequired;
    [Token(Token = "0x4000339")]
    [FieldOffset(Offset = "0x21")]
    public bool IsShared;
    [Token(Token = "0x400033A")]
    [FieldOffset(Offset = "0x22")]
    public bool IsScene;
    [Token(Token = "0x400033B")]
    [FieldOffset(Offset = "0x23")]
    public bool IsSubAsset;
    [Token(Token = "0x400033C")]
    [FieldOffset(Offset = "0x24")]
    public bool IsCompressed;
    [Token(Token = "0x400033D")]
    [FieldOffset(Offset = "0x28")]
    public List<DependencyGraph.Node> Dependencies;

    [Token(Token = "0x170000AB")]
    public DependencyGraph.NodeFlags Flags
    {
      [Token(Token = "0x60003F9"), Address(RVA = "0xB8D870", Offset = "0xB8C670", VA = "0x10B8D870")] get
      {
        return new DependencyGraph.NodeFlags();
      }
      [Token(Token = "0x60003FA"), Address(RVA = "0xB8D8B0", Offset = "0xB8C6B0", VA = "0x10B8D8B0")] set
      {
      }
    }

    [Token(Token = "0x60003FB")]
    [Address(RVA = "0xB8D800", Offset = "0xB8C600", VA = "0x10B8D800")]
    public Node()
    {
    }
  }
}
