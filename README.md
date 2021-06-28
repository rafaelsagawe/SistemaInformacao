# SistemaInformacao

## Será usado o MySQL como SGBD
A integração foi feita com o Pomelo instalados via Nuget

* Pomelo.EntityFrameworkCore.MySql
* Pomelo.EntityFrameworkCore.MySql.Design
* Microsoft.EntityFrameworkCore.Tools

## Instalação do SQLServer no Linux

O servidor de banco de dados sera o SQLServer durante o desenvolvimento postoriormento pode ser trocado para outro SGBD.

O sistema usará um container do ProxMox usando o Ubuntu.

~~~~shell
# wget -qO- https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -

# sudo add-apt-repository "$(wget -qO- https://packages.microsoft.com/config/ubuntu/18.04/mssql-server-2019.list)"

# sudo apt-get update
# sudo apt-get install -y mssql-server

mssql-server (15.0.4138.2-1)

# sudo /opt/mssql/bin/mssql-conf setup

3 - Express

# systemctl status mssql-server --no-pager

# apt install curl

curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -

curl https://packages.microsoft.com/config/ubuntu/18.04/prod.list | sudo tee /etc/apt/sources.list.d/msprod.list

sudo apt-get update 

sudo apt-get install mssql-tools unixodbc-dev

echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc

source ~/.bashrc

sqlcmd -S localhost -U SA -P '----------'
~~~~