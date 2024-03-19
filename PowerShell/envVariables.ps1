Get-ChildItem Env:
$Env:EIN_IMAGE #prints our environments image build
$Env:NEW_VAR = "test" #Creates a global variable. This could be useful for encoding payloads locally using base64 after initial access
