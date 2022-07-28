<style>
        .btn-ok{
			background: green;
		}
    </style>

<!-- Begin Page Content -->
<div class="container-fluid">

	<!-- Page Heading -->
	<div class="col-lg-12">
        <h1 class="h3 mb-4" style="color: black;">Data obat</h1>
		<div class="card shadow mb-4">
			<div class="card-header py-3">
				<h6 class="m-0 font-weight-bold" style="color: green;">List obat</h6>
			</div>
			<div class="card-body">
				<?php if ($this->session->flashdata('info')) : ?>
					<div class="alert alert-danger">
						<?php echo $this->session->flashdata('info'); ?>
					</div>
				<?php endif; ?>
				<table class="table table-bordered" id="dataTable" style="color: black;">
					<thead>
						<tr>
							<th>#</th>
							<th>Kode Obat</th>
							<th>Nama Obat</th>
							<th>Harga</th>
							<th>Produsen</th>
							<th>Supplier</th>
							<th>Stok</th>
							<th>Opsi</th>
						</tr>
					</thead>
					<?php $no = 1; ?>
					<?php foreach($obat->result() as $o) : ?>
					<tbody>
						<tr>
							<td><?php echo $no++; ?></td>
							<td><?php echo $o->kode; ?></td>
							<td><?php echo $o->nama_obat; ?></td>
							<td><?php echo $o->harga; ?></td>
							<td><?php echo $o->produsen; ?></td>
							<td><?php echo $o->supplier_id; ?></td>
							<td><?php echo $o->stok; ?></td>
							<td>
								<a href="<?php echo site_url('obat/hapus/') . $o->kode; ?>" class="btn btn-danger btn-circle btn-sm"><i class="fa fa-trash"></i></a>
								<a href="<?php echo site_url('obat/ubah/') . $o->kode; ?>" class="btn btn-ok btn-circle btn-sm" style="color: white;"><i class="fa fa-edit"></i></a>
							</td>
						</tr>
					</tbody>
					<?php endforeach ?>
				</table>
			</div>
		</div>
	</div>
</div>
<!-- /.container-fluid -->
