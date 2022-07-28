	<style>
        .btn-ok{
			background: green;
		}
    </style>

<!-- Begin Page Content -->
<div class="container-fluid">

	<!-- Page Heading -->
	<!-- <h1 class="h3 mb-4 text-gray-800">Tambah Data obat</h1> -->
	<div class="col-lg-8">
		<div class="card shadow mb-4">
			<div class="card-header py-3">
				<h6 class="m-0 font-weight-bold" style="color: green;">Form tambah data obat</h6>
			</div>
			<div class="card-body" style="color: black;">
                <form action="" method="post" enctype="multipart/form-data">
                    <?php if ($this->session->flashdata('info')) : ?>
                    <div class="alert alert-danger">
                        <?php echo $this->session->flashdata('info'); ?>
                    </div>
                    <?php endif; ?>
                    <?php echo validation_errors('<div class="alert alert-danger">', '</div>'); ?>
					<div class="form-group">
						<label for="kode-obat">Kode Obat</label>
						<input type="text" name="kode_obat" id="kode-obat" class="form-control">
					</div>
					<div class="form-group">
                        <label for="supplier">Supplier</label>
                        <?php echo form_dropdown('supplier', $supplier, set_value('supplier'), ['class' => 'form-control', 'id' => 'supplier']) ?>
					</div>
					<div class="form-group">
						<label for="nama-obat">Nama Obat</label>
						<input type="text" name="nama" id="nama-obat" class="form-control">
					</div>
					<div class="form-group">
						<label for="produsen">Produsen</label>
						<input type="text" name="produsen" id="produsen" class="form-control">
					</div>
					<div class="form-group">
						<label for="harga">Harga</label>
						<input type="number" name="harga" id="harga" class="form-control">
					</div>
					<div class="form-group">
						<label for="stok">Jumlah stok</label>
						<input type="number" name="stok" id="stok" class="form-control">
					</div>
                    <button type="submit" name="submit" class="btn btn-ok" style="color: white;">Submit</button>
                    <button type="reset" class="btn btn-danger">Reset</button>
				</form>
			</div>
		</div>
	</div>
</div>
<!-- /.container-fluid -->
