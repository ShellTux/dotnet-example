{
  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixpkgs-unstable";
    flake-parts.url = "github:hercules-ci/flake-parts";
  };

  outputs =
    inputs@{ self, ... }:
    inputs.flake-parts.lib.mkFlake { inherit inputs; } {
      systems = [
        "aarch64-darwin"
        "x86_64-darwin"
        "x86_64-linux"
      ];

      perSystem =
        { pkgs, ... }:
        {
          devShells =
            let
              dotnet = pkgs.dotnetCorePackages.sdk_9_0;
            in
            {
              default = pkgs.mkShell {
                nativeBuildInputs = [ dotnet ];

                DOTNET_BIN = "${dotnet}/bin/dotnet";
              };
            };
        };
    };
}
